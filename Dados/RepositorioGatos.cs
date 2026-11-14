using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miaudota
{
    internal class RepositorioGatos
    {
        private static List<Gato> cache = new List<Gato>();

        //objeto para controlar o acesso ao cache
        private static readonly object bloqueio = new object();

        private const int LIMITE_CACHE = 5;

        // retorna quantos gatos estão aguardando o envio para o banco
        public static int QuantidadePendente()
        {
            lock (bloqueio)
            {
                return cache.Count;
            }
        }

        public static void Adicionar(Gato gato)
        {
            if (gato == null)
            {
                throw new ArgumentNullException(nameof(gato));
            }

            bool sincronizar;

            lock (bloqueio)
            {
                // Evita adicionar o mesmo microchip duas vezes ao cache.
                if (!string.IsNullOrWhiteSpace(gato.NumeroMicrochip) &&
                    cache.Any(g => g.NumeroMicrochip == gato.NumeroMicrochip))
                {
                    throw new InvalidOperationException(
                        "Já existe um gato com esse microchip aguardando sincronização.");
                }

                cache.Add(gato);
                sincronizar = cache.Count >= LIMITE_CACHE;
            }

            if (sincronizar)
            {
                Sincronizar();
            }
        }

        public static void Sincronizar()
        {
            List<Gato> lote;

            lock (bloqueio)
            {
                if (cache.Count == 0)
                    return;

                lote = cache.ToList();
            }

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        foreach (Gato gato in lote)
                        {
                            InserirGato(conexao, transacao, gato);
                        }

                        transacao.Commit();

                        lock (bloqueio)
                        {
                            foreach (Gato gato in lote)
                            {
                                cache.Remove(gato);
                            }
                        }
                    }
                    catch
                    {
                        transacao.Rollback();
                        throw;
                    }
                }
            }

        }

        private static void InserirGato(MySqlConnection conexao, MySqlTransaction transacao, Gato gato)
        {
            int idPelagem = ObterId(conexao, transacao, "SELECT id_pelagem FROM pelagem WHERE descricao = @descricao", gato.Pelagem);

            int idColoracao = ObterId(
                conexao, transacao,
                "SELECT id_coloracao FROM coloracao WHERE descricao = @descricao",
                gato.Coloracao);

            int idStatus = ObterId(
                conexao, transacao,
                "SELECT id_status FROM status_gato WHERE descricao = @descricao",
                gato.Status);

            int idFiv = ObterId(
                conexao, transacao,
                "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao",
                gato.TesteFIV);

            int idFelv = ObterId(
                conexao, transacao,
                "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao",
                gato.TesteFelv);

            string sql = @"
                INSERT INTO gato
                (
                    microchip,
                    nome,
                    data_nascimento,
                    sexo,
                    id_pelagem,
                    id_coloracao,
                    peso_kg,
                    id_lar_temporario,
                    castrado,
                    vacinas_em_dia,
                    id_status,
                    id_teste_fiv,
                    id_teste_felv,
                    doenca_deficiencia,
                    observacoes,
                    data_entrada,
                    foto_binario
                )
                VALUES
                (
                    @microchip,
                    @nome,
                    @dataNascimento,
                    @sexo,
                    @idPelagem,
                    @idColoracao,
                    @peso,
                    @idLar,
                    @castrado,
                    @vacinasEmDia,
                    @idStatus,
                    @idFiv,
                    @idFelv,
                    @doencas,
                    @observacoes,
                    @dataEntrada,
                    @fotoBinario
                );";

            int idGato;

            using (MySqlCommand comando = new MySqlCommand(sql,conexao, transacao))
            {
                comando.Parameters.AddWithValue("@microchip",
                    string.IsNullOrWhiteSpace(gato.NumeroMicrochip)
                    ? (object)DBNull.Value : gato.NumeroMicrochip);

                comando.Parameters.AddWithValue("@nome", gato.Nome);
                comando.Parameters.AddWithValue("@dataNascimento", gato.DataNascimento.Date);
                comando.Parameters.AddWithValue("@sexo", gato.Sexo);
                comando.Parameters.AddWithValue("@idPelagem", idPelagem);
                comando.Parameters.AddWithValue("@idColoracao", idColoracao);

                comando.Parameters.AddWithValue("@peso",
                    gato.Peso > 0
                    ? (object)Convert.ToDecimal(gato.Peso)
                    : DBNull.Value);

                comando.Parameters.AddWithValue("@idLar",
                    gato.IdLarTemporario.HasValue
                    ? (object)gato.IdLarTemporario.Value
                    : DBNull.Value);

                comando.Parameters.AddWithValue("@castrado",
                    gato.Castrado == "Sim");

                comando.Parameters.AddWithValue("@vacinasEmDia",
                    gato.VacinasEmDia == "Sim");

                comando.Parameters.AddWithValue("@idStatus", idStatus);
                comando.Parameters.AddWithValue("@idFiv", idFiv);
                comando.Parameters.AddWithValue("@idFelv", idFelv);

                comando.Parameters.AddWithValue("@doencas",
                    string.IsNullOrWhiteSpace(gato.Doencas)
                    ? (object)DBNull.Value : gato.Doencas);

                comando.Parameters.AddWithValue("@observacoes",
                    string.IsNullOrWhiteSpace(gato.Observacoes)
                    ? (object)DBNull.Value : gato.Observacoes);

                comando.Parameters.AddWithValue("@dataEntrada", gato.DataChegadaOng.Date);

                comando.Parameters.Add("@fotoBinario", MySqlDbType.LongBlob).Value =
                    (object)gato.Foto ?? DBNull.Value;

                comando.ExecuteNonQuery();

                idGato = Convert.ToInt32(comando.LastInsertedId);
            }

            // Inserir as vacinas selecionadas.
            foreach (string nomeVacina in gato.Vacinas.Distinct())
            {
                int idVacina = ObterId(
                    conexao,
                    transacao,
                    "SELECT id_vacina FROM vacina WHERE nome = @descricao",
                    nomeVacina);

                string sqlVacina = @"
                    INSERT INTO gato_vacina (id_gato, id_vacina)
                    VALUES (@idGato, @idVacina);";

                using (MySqlCommand comandoVacina =
                    new MySqlCommand(sqlVacina, conexao, transacao))
                {
                    comandoVacina.Parameters.AddWithValue("@idGato", idGato);
                    comandoVacina.Parameters.AddWithValue("@idVacina", idVacina);
                    comandoVacina.ExecuteNonQuery();
                }
            }

            // Inserir o local de resgate, quando informado.
            if (gato.Latitude.HasValue && gato.Longitude.HasValue)
            {
                string sqlLocal = @"
                    INSERT INTO local_resgate
                    (id_gato, latitude, longitude)
                    VALUES
                    (@idGato, @latitude, @longitude);";

                using (MySqlCommand comandoLocal =
                    new MySqlCommand(sqlLocal, conexao, transacao))
                {
                    comandoLocal.Parameters.AddWithValue("@idGato", idGato);
                    comandoLocal.Parameters.AddWithValue("@latitude", gato.Latitude.Value);
                    comandoLocal.Parameters.AddWithValue("@longitude", gato.Longitude.Value);

                    comandoLocal.ExecuteNonQuery();
                }
            }
            else if (gato.Latitude.HasValue || gato.Longitude.HasValue)
            {
                throw new InvalidOperationException(
                    "A latitude e a longitude do local de resgate devem ser informadas juntas.");
            }
        }

        public static List<Gato> ObterDisponiveis()
        {
            List<Gato> lista = new List<Gato>();

            string sql = @"
                SELECT g.id_gato, g.microchip, g.nome, g.sexo
                FROM gato g
                INNER JOIN status_gato s ON g.id_status = s.id_status
                WHERE s.descricao = 'Disponível'
                ORDER BY g.nome";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Gato gato = new Gato();
                        gato.Id = Convert.ToInt32(leitor["id_gato"]);

                        // o setter do microchip lança exceção se vier vazio, então só atribui se existir
                        if (leitor["microchip"] != DBNull.Value)
                        {
                            gato.NumeroMicrochip = Convert.ToString(leitor["microchip"]);
                        }

                        gato.Nome = Convert.ToString(leitor["nome"]);
                        gato.Sexo = Convert.ToString(leitor["sexo"]);
                        lista.Add(gato);
                    }
                }
            }
            return lista;
        }

        public static List<Gato> ObterTodos()
        {
            List<Gato> lista = new List<Gato>();
            Dictionary<int, Gato> porId = new Dictionary<int, Gato>();

            string sql = @"
                SELECT g.id_gato, g.microchip, g.nome, g.data_nascimento, g.sexo,
                       p.descricao AS pelagem, c.descricao AS coloracao,
                       g.peso_kg, g.id_lar_temporario, lt.nome_completo AS lar,
                       g.castrado, g.vacinas_em_dia, sg.descricao AS status,
                       fiv.descricao AS teste_fiv, felv.descricao AS teste_felv,
                       g.doenca_deficiencia, g.observacoes, g.data_entrada,
                       g.foto_binario, lr.latitude, lr.longitude,
                       (SELECT MAX(a.data_adocao) FROM adocao a
                         WHERE a.id_gato = g.id_gato AND a.ativa = TRUE) AS data_adocao
                FROM gato g
                INNER JOIN pelagem p ON g.id_pelagem = p.id_pelagem
                INNER JOIN coloracao c ON g.id_coloracao = c.id_coloracao
                INNER JOIN status_gato sg ON g.id_status = sg.id_status
                INNER JOIN resultado_teste fiv ON g.id_teste_fiv = fiv.id_resultado
                INNER JOIN resultado_teste felv ON g.id_teste_felv = felv.id_resultado
                LEFT JOIN lar_temporario lt ON g.id_lar_temporario = lt.id_lar_temporario
                LEFT JOIN local_resgate lr ON lr.id_gato = g.id_gato
                ORDER BY g.nome;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Gato gato = new Gato();
                        gato.Id = Convert.ToInt32(leitor["id_gato"]);

                        if (leitor["microchip"] != DBNull.Value)
                            gato.NumeroMicrochip = Convert.ToString(leitor["microchip"]);

                        gato.Nome = Convert.ToString(leitor["nome"]);

                        if (leitor["data_nascimento"] != DBNull.Value)
                            gato.DataNascimento = Convert.ToDateTime(leitor["data_nascimento"]);

                        gato.Sexo = Convert.ToString(leitor["sexo"]);
                        gato.Pelagem = Convert.ToString(leitor["pelagem"]);
                        gato.Coloracao = Convert.ToString(leitor["coloracao"]);

                        if (leitor["peso_kg"] != DBNull.Value)
                            gato.Peso = Convert.ToSingle(leitor["peso_kg"]);

                        if (leitor["id_lar_temporario"] != DBNull.Value)
                        {
                            gato.IdLarTemporario = Convert.ToInt32(leitor["id_lar_temporario"]);
                            gato.LarTemporario = Convert.ToString(leitor["lar"]);
                        }

                        gato.Castrado = Convert.ToBoolean(leitor["castrado"]) ? "Sim" : "Não";
                        gato.VacinasEmDia = Convert.ToBoolean(leitor["vacinas_em_dia"]) ? "Sim" : "Não";
                        gato.Status = Convert.ToString(leitor["status"]);
                        gato.TesteFIV = Convert.ToString(leitor["teste_fiv"]);
                        gato.TesteFelv = Convert.ToString(leitor["teste_felv"]);

                        if (leitor["doenca_deficiencia"] != DBNull.Value)
                            gato.Doencas = Convert.ToString(leitor["doenca_deficiencia"]);

                        if (leitor["observacoes"] != DBNull.Value)
                            gato.Observacoes = Convert.ToString(leitor["observacoes"]);

                        gato.DataChegadaOng = Convert.ToDateTime(leitor["data_entrada"]);
                        gato.Foto = leitor["foto_binario"] as byte[];

                        if (leitor["latitude"] != DBNull.Value && leitor["longitude"] != DBNull.Value)
                        {
                            gato.Latitude = Convert.ToDouble(leitor["latitude"]);
                            gato.Longitude = Convert.ToDouble(leitor["longitude"]);
                            gato.LocalResgate = "Sim";
                        }
                        else
                        {
                            gato.LocalResgate = "Não";
                        }

                        if (leitor["data_adocao"] != DBNull.Value)
                            gato.Data_Adocao = Convert.ToDateTime(leitor["data_adocao"]);

                        lista.Add(gato);
                        porId[gato.Id] = gato;
                    }
                }

                // vacinas de todos os gatos em uma única consulta
                string sqlVacinas = @"
                    SELECT gv.id_gato, v.nome
                    FROM gato_vacina gv
                    INNER JOIN vacina v ON gv.id_vacina = v.id_vacina;";

                using (MySqlCommand comando = new MySqlCommand(sqlVacinas, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int idGato = Convert.ToInt32(leitor["id_gato"]);
                        if (porId.ContainsKey(idGato))
                        {
                            porId[idGato].Vacinas.Add(Convert.ToString(leitor["nome"]));
                        }
                    }
                }
            }

            return lista;
        }

        public static List<Gato> ObterAdotadosPorTutor(int idTutor)
        {
            List<Gato> lista = new List<Gato>();

            string sql = @"
                SELECT g.id_gato, g.microchip, g.nome, g.data_nascimento, g.sexo,
                       p.descricao AS pelagem, c.descricao AS coloracao,
                       g.peso_kg, g.foto_binario, a.data_adocao
                FROM adocao a
                INNER JOIN gato g ON a.id_gato = g.id_gato
                INNER JOIN pelagem p ON g.id_pelagem = p.id_pelagem
                INNER JOIN coloracao c ON g.id_coloracao = c.id_coloracao
                WHERE a.id_tutor = @idTutor AND a.ativa = TRUE
                ORDER BY a.data_adocao DESC;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@idTutor", idTutor);

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Gato gato = new Gato();
                            gato.Id = Convert.ToInt32(leitor["id_gato"]);

                            if (leitor["microchip"] != DBNull.Value)
                                gato.NumeroMicrochip = Convert.ToString(leitor["microchip"]);

                            gato.Nome = Convert.ToString(leitor["nome"]);

                            if (leitor["data_nascimento"] != DBNull.Value)
                                gato.DataNascimento = Convert.ToDateTime(leitor["data_nascimento"]);

                            gato.Sexo = Convert.ToString(leitor["sexo"]);
                            gato.Pelagem = Convert.ToString(leitor["pelagem"]);
                            gato.Coloracao = Convert.ToString(leitor["coloracao"]);

                            if (leitor["peso_kg"] != DBNull.Value)
                                gato.Peso = Convert.ToSingle(leitor["peso_kg"]);

                            gato.Foto = leitor["foto_binario"] as byte[];
                            gato.Data_Adocao = Convert.ToDateTime(leitor["data_adocao"]);

                            lista.Add(gato);
                        }
                    }
                }
            }

            return lista;
        }

        private static void SincronizarComAviso()
        {
            try
            {
                Sincronizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de gatos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static Gato ObterPorMicrochip(string microchip)
        {
            SincronizarComAviso();

            string sql = @"
                SELECT g.id_gato, g.microchip, g.nome, g.sexo, s.descricao AS status
                FROM gato g
                INNER JOIN status_gato s ON g.id_status = s.id_status
                WHERE g.microchip = @microchip
                LIMIT 1;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@microchip", microchip);

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        if (!leitor.Read())
                        {
                            return null;
                        }

                        Gato gato = new Gato();
                        gato.Id = Convert.ToInt32(leitor["id_gato"]);
                        gato.NumeroMicrochip = Convert.ToString(leitor["microchip"]);
                        gato.Nome = Convert.ToString(leitor["nome"]);
                        gato.Sexo = Convert.ToString(leitor["sexo"]);
                        gato.Status = Convert.ToString(leitor["status"]);
                        return gato;
                    }
                }
            }
        }

        public static void Atualizar(Gato gato)
        {
            if (gato == null)
            {
                throw new ArgumentNullException(nameof(gato));
            }

            if ((gato.Latitude.HasValue) != (gato.Longitude.HasValue))
            {
                throw new InvalidOperationException(
                    "A latitude e a longitude do local de resgate devem ser informadas juntas.");
            }

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        int idPelagem = ObterId(conexao, transacao,
                            "SELECT id_pelagem FROM pelagem WHERE descricao = @descricao", gato.Pelagem);
                        int idColoracao = ObterId(conexao, transacao,
                            "SELECT id_coloracao FROM coloracao WHERE descricao = @descricao", gato.Coloracao);
                        int idStatus = ObterId(conexao, transacao,
                            "SELECT id_status FROM status_gato WHERE descricao = @descricao", gato.Status);
                        int idFiv = ObterId(conexao, transacao,
                            "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao", gato.TesteFIV);
                        int idFelv = ObterId(conexao, transacao,
                            "SELECT id_resultado FROM resultado_teste WHERE descricao = @descricao", gato.TesteFelv);

                        string sql = @"
                    UPDATE gato SET
                        microchip = @microchip,
                        nome = @nome,
                        data_nascimento = @dataNascimento,
                        sexo = @sexo,
                        id_pelagem = @idPelagem,
                        id_coloracao = @idColoracao,
                        peso_kg = @peso,
                        id_lar_temporario = @idLar,
                        castrado = @castrado,
                        vacinas_em_dia = @vacinasEmDia,
                        id_status = @idStatus,
                        id_teste_fiv = @idFiv,
                        id_teste_felv = @idFelv,
                        doenca_deficiencia = @doencas,
                        observacoes = @observacoes,
                        data_entrada = @dataEntrada,
                        foto_binario = @fotoBinario
                    WHERE id_gato = @id;";

                        using (MySqlCommand comando = new MySqlCommand(sql, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@microchip",
                                string.IsNullOrWhiteSpace(gato.NumeroMicrochip)
                                ? (object)DBNull.Value : gato.NumeroMicrochip);
                            comando.Parameters.AddWithValue("@nome", gato.Nome);
                            comando.Parameters.AddWithValue("@dataNascimento", gato.DataNascimento.Date);
                            comando.Parameters.AddWithValue("@sexo", gato.Sexo);
                            comando.Parameters.AddWithValue("@idPelagem", idPelagem);
                            comando.Parameters.AddWithValue("@idColoracao", idColoracao);
                            comando.Parameters.AddWithValue("@peso",
                                gato.Peso > 0 ? (object)Convert.ToDecimal(gato.Peso) : DBNull.Value);
                            comando.Parameters.AddWithValue("@idLar",
                                gato.IdLarTemporario.HasValue
                                ? (object)gato.IdLarTemporario.Value : DBNull.Value);
                            comando.Parameters.AddWithValue("@castrado", gato.Castrado == "Sim");
                            comando.Parameters.AddWithValue("@vacinasEmDia", gato.VacinasEmDia == "Sim");
                            comando.Parameters.AddWithValue("@idStatus", idStatus);
                            comando.Parameters.AddWithValue("@idFiv", idFiv);
                            comando.Parameters.AddWithValue("@idFelv", idFelv);
                            comando.Parameters.AddWithValue("@doencas",
                                string.IsNullOrWhiteSpace(gato.Doencas)
                                ? (object)DBNull.Value : gato.Doencas);
                            comando.Parameters.AddWithValue("@observacoes",
                                string.IsNullOrWhiteSpace(gato.Observacoes)
                                ? (object)DBNull.Value : gato.Observacoes);
                            comando.Parameters.AddWithValue("@dataEntrada", gato.DataChegadaOng.Date);
                            comando.Parameters.Add("@fotoBinario", MySqlDbType.LongBlob).Value =
                                (object)gato.Foto ?? DBNull.Value;
                            comando.Parameters.AddWithValue("@id", gato.Id);
                            comando.ExecuteNonQuery();
                        }

                        // vacinas: apaga e grava de novo as selecionadas
                        using (MySqlCommand comando = new MySqlCommand(
                            "DELETE FROM gato_vacina WHERE id_gato = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", gato.Id);
                            comando.ExecuteNonQuery();
                        }

                        foreach (string nomeVacina in gato.Vacinas.Distinct())
                        {
                            int idVacina = ObterId(conexao, transacao,
                                "SELECT id_vacina FROM vacina WHERE nome = @descricao", nomeVacina);

                            using (MySqlCommand comando = new MySqlCommand(
                                "INSERT INTO gato_vacina (id_gato, id_vacina) VALUES (@idGato, @idVacina);",
                                conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@idGato", gato.Id);
                                comando.Parameters.AddWithValue("@idVacina", idVacina);
                                comando.ExecuteNonQuery();
                            }
                        }

                        // local de resgate: apaga e grava de novo, se informado
                        using (MySqlCommand comando = new MySqlCommand(
                            "DELETE FROM local_resgate WHERE id_gato = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", gato.Id);
                            comando.ExecuteNonQuery();
                        }

                        if (gato.Latitude.HasValue && gato.Longitude.HasValue)
                        {
                            using (MySqlCommand comando = new MySqlCommand(
                                @"INSERT INTO local_resgate (id_gato, latitude, longitude)
                          VALUES (@idGato, @latitude, @longitude);",
                                conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@idGato", gato.Id);
                                comando.Parameters.AddWithValue("@latitude", gato.Latitude.Value);
                                comando.Parameters.AddWithValue("@longitude", gato.Longitude.Value);
                                comando.ExecuteNonQuery();
                            }
                        }

                        transacao.Commit();
                    }
                    catch
                    {
                        transacao.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void Excluir(Gato gato)
        {
            if (gato == null)
            {
                throw new ArgumentNullException(nameof(gato));
            }

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand comando = new MySqlCommand(
                            "DELETE FROM gato_vacina WHERE id_gato = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", gato.Id);
                            comando.ExecuteNonQuery();
                        }

                        using (MySqlCommand comando = new MySqlCommand(
                            "DELETE FROM gato WHERE id_gato = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", gato.Id);
                            comando.ExecuteNonQuery();
                        }

                        transacao.Commit();
                    }
                    catch (MySqlException ex) when (ex.Number == 1451)
                    {
                        transacao.Rollback();
                        throw new InvalidOperationException(
                            "Este gato possui adoção ou ocorrência registrada e não pode ser excluído.");
                    }
                    catch
                    {
                        transacao.Rollback();
                        throw;
                    }
                }
            }
        }

        internal static int ObterId(
            MySqlConnection conexao,
            MySqlTransaction transacao,
            string sql,
            string descricao)
        {
            using (MySqlCommand comando = new MySqlCommand(sql, conexao, transacao))
            {
                comando.Parameters.AddWithValue("@descricao", descricao);

                object resultado = comando.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new InvalidOperationException(
                        "Não foi encontrado no banco o cadastro: " + descricao);
                }

                return Convert.ToInt32(resultado);
            }
        }
    }
}
