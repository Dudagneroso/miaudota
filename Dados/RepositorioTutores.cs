using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miaudota
{
    internal class RepositorioTutores
    {
        public static List<Tutor> ObterTodos()
        {
            List<Tutor> lista = new List<Tutor>();

            string sql = @"
                SELECT t.id, t.cpf, t.nome, t.telefone, t.data_nascimento, t.email,
                       e.numero, c.cep, c.logradouro, c.bairro,
                       ci.nome AS cidade, es.sigla AS estado,
                       tm.descricao AS tipo_moradia,
                       oa.descricao AS outros_animais
                FROM tutor t
                INNER JOIN endereco e ON t.id_endereco = e.id_endereco
                INNER JOIN cep c ON e.cep = c.cep
                INNER JOIN cidade ci ON c.id_cidade = ci.id_cidade
                INNER JOIN estado es ON ci.id_estado = es.id_estado
                INNER JOIN tipo_moradia tm ON t.id_tipo_moradia = tm.id_tipo_moradia
                INNER JOIN opcao_outros_animais oa ON t.id_outros_pets = oa.id_opcao
                ORDER BY t.nome;";

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Tutor tutor = new Tutor();
                        tutor.Id = Convert.ToInt32(leitor["id"]);
                        tutor.CPF = Convert.ToString(leitor["cpf"]);
                        tutor.Nome = Convert.ToString(leitor["nome"]);
                        tutor.Telefone = Convert.ToString(leitor["telefone"]);
                        tutor.DataNascimento = Convert.ToDateTime(leitor["data_nascimento"]);
                        tutor.Email = Convert.ToString(leitor["email"]);
                        tutor.CEP = Convert.ToString(leitor["cep"]);
                        tutor.Logradouro = Convert.ToString(leitor["logradouro"]);
                        tutor.Bairro = Convert.ToString(leitor["bairro"]);
                        tutor.Cidade = Convert.ToString(leitor["cidade"]);
                        tutor.Estado = Convert.ToString(leitor["estado"]);
                        tutor.TipoResidencia = Convert.ToString(leitor["tipo_moradia"]);
                        tutor.OutrosAnimais = Convert.ToString(leitor["outros_animais"]);

                        int numero;
                        int.TryParse(Convert.ToString(leitor["numero"]), out numero);
                        tutor.Numero = numero;

                        lista.Add(tutor);
                    }
                }
            }

            return lista;
        }

        public static void Adicionar(Tutor tutor, Gato gato)
        {
            if (tutor == null)
            {
                throw new ArgumentNullException(nameof(tutor));
            }

            string cpf = ApenasDigitos(tutor.CPF);
            string telefone = ApenasDigitos(tutor.Telefone);
            string cep = ApenasDigitos(tutor.CEP);

            if (cpf.Length != 11)
                throw new ArgumentException("O CPF deve ter 11 dígitos.");
            if (telefone.Length < 10 || telefone.Length > 11)
                throw new ArgumentException("O telefone deve ter 10 ou 11 dígitos.");
            if (cep.Length != 8)
                throw new ArgumentException("O CEP deve ter 8 dígitos.");
            if (string.IsNullOrWhiteSpace(tutor.TipoResidencia))
                throw new ArgumentException("Selecione o tipo de moradia.");
            if (string.IsNullOrWhiteSpace(tutor.OutrosAnimais))
                throw new ArgumentException("Informe se há outros animais.");

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        // estado precisa existir (aceita sigla ou nome)
                        int idEstado = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_estado FROM estado WHERE sigla = @descricao OR nome = @descricao LIMIT 1",
                            tutor.Estado.Trim());

                        int idCidade = ObterOuCriarCidade(conexao, transacao, tutor.Cidade.Trim(), idEstado);

                        // cep (insere ou atualiza)
                        string sqlCep = @"
                            INSERT INTO cep (cep, logradouro, bairro, id_cidade)
                            VALUES (@cep, @logradouro, @bairro, @idCidade)
                            ON DUPLICATE KEY UPDATE
                                logradouro = @logradouro,
                                bairro = @bairro,
                                id_cidade = @idCidade;";

                        using (MySqlCommand comando = new MySqlCommand(sqlCep, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cep", cep);
                            comando.Parameters.AddWithValue("@logradouro", tutor.Logradouro.Trim());
                            comando.Parameters.AddWithValue("@bairro", tutor.Bairro.Trim());
                            comando.Parameters.AddWithValue("@idCidade", idCidade);
                            comando.ExecuteNonQuery();
                        }

                        // endereco
                        int idEndereco;
                        using (MySqlCommand comando = new MySqlCommand(
                            "INSERT INTO endereco (cep, numero) VALUES (@cep, @numero);",
                            conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cep", cep);
                            comando.Parameters.AddWithValue("@numero", tutor.Numero.ToString());
                            comando.ExecuteNonQuery();
                            idEndereco = Convert.ToInt32(comando.LastInsertedId);
                        }

                        int idMoradia = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_tipo_moradia FROM tipo_moradia WHERE descricao = @descricao",
                            tutor.TipoResidencia);

                        int idOutrosPets = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_opcao FROM opcao_outros_animais WHERE descricao = @descricao",
                            tutor.OutrosAnimais);

                        // tutor
                        string sqlTutor = @"
                            INSERT INTO tutor
                            (cpf, nome, telefone, data_nascimento, email,
                             id_endereco, id_tipo_moradia, id_outros_pets)
                            VALUES
                            (@cpf, @nome, @telefone, @dataNascimento, @email,
                             @idEndereco, @idMoradia, @idOutrosPets);";

                        int idTutor;
                        using (MySqlCommand comando = new MySqlCommand(sqlTutor, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cpf", cpf);
                            comando.Parameters.AddWithValue("@nome", tutor.Nome.Trim());
                            comando.Parameters.AddWithValue("@telefone", telefone);
                            comando.Parameters.AddWithValue("@dataNascimento", tutor.DataNascimento.Date);
                            comando.Parameters.AddWithValue("@email", tutor.Email.Trim());
                            comando.Parameters.AddWithValue("@idEndereco", idEndereco);
                            comando.Parameters.AddWithValue("@idMoradia", idMoradia);
                            comando.Parameters.AddWithValue("@idOutrosPets", idOutrosPets);
                            comando.ExecuteNonQuery();
                            idTutor = Convert.ToInt32(comando.LastInsertedId);
                        }

                        // adoção (só se houver gato selecionado)
                        if (gato != null)
                        {
                            // marca como Adotado somente se ainda estiver Disponível
                            string sqlStatus = @"
                                UPDATE gato
                                SET id_status = (SELECT id_status FROM status_gato WHERE descricao = 'Adotado')
                                WHERE id_gato = @idGato
                                  AND id_status = (SELECT id_status FROM status_gato WHERE descricao = 'Disponível');";

                            using (MySqlCommand comando = new MySqlCommand(sqlStatus, conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@idGato", gato.Id);

                                if (comando.ExecuteNonQuery() == 0)
                                {
                                    throw new InvalidOperationException(
                                        "Este gato não está mais disponível para adoção.");
                                }
                            }

                            string sqlAdocao = @"
                                INSERT INTO adocao (id_gato, id_tutor, data_adocao)
                                VALUES (@idGato, @idTutor, CURDATE());";

                            using (MySqlCommand comando = new MySqlCommand(sqlAdocao, conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@idGato", gato.Id);
                                comando.Parameters.AddWithValue("@idTutor", idTutor);
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

        public static void Excluir(Tutor tutor)
        {
            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using(MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        // devolve os gatos adotados por este tutor para Disponível
                        string sqlGatos = @"
                            UPDATE gato
                            SET id_status = (SELECT id_status FROM status_gato WHERE descricao = 'Disponível')
                            WHERE id_gato IN (SELECT id_gato FROM adocao WHERE id_tutor = @id);";

                        using (MySqlCommand comando = new MySqlCommand(sqlGatos, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            comando.ExecuteNonQuery();
                        }

                        using (MySqlCommand comando = new MySqlCommand("DELETE FROM adocao WHERE id_tutor = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            comando.ExecuteNonQuery();
                        }

                        // guarda o endereço antes de apagar o tutor
                        object idEndereco;
                        using (MySqlCommand comando = new MySqlCommand("SELECT id_endereco FROM tutor WHERE id = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            idEndereco = comando.ExecuteScalar();
                        }

                        using (MySqlCommand comando = new MySqlCommand("DELETE FROM tutor WHERE id = @id;", conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            comando.ExecuteNonQuery();
                        }

                        // apaga o endereço se ninguém mais usa
                        if (idEndereco != null && idEndereco != DBNull.Value)
                        {
                            string sqlEndereco = @"
                                DELETE FROM endereco
                                WHERE id_endereco = @idEndereco
                                    AND NOT EXISTS (SELECT 1 FROM tutor WHERE id_endereco = @idEndereco)
                                    AND NOT EXISTS (SELECT 1 FROM lar_temporario WHERE id_endereco = @idEndereco);";

                            using (MySqlCommand comando = new MySqlCommand(sqlEndereco, conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@idEndereco", idEndereco);
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

        public static void Atualizar(Tutor tutor)
        {
            string cpf = ApenasDigitos(tutor.CPF);
            string telefone = ApenasDigitos(tutor.Telefone);
            string cep = ApenasDigitos(tutor.CEP);

            if (cpf.Length != 11)
            {
                throw new ArgumentException("O CPF deve ter 11 dígitos.");
            }
            if (telefone.Length <10 || telefone.Length > 11)
            {
                throw new ArgumentException("O telefone deve ter 10 ou 11 dígitos.");
            }
            if (cep.Length != 8)
            {
                throw new ArgumentException("O CEP deve ter 8 dígitos.");
            }

            using (MySqlConnection conexao = Conexao.Obter())
            {
                conexao.Open();

                using (MySqlTransaction transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        int idEstado = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_estado FROM estado WHERE sigla = @descricao OR nome = @descricao LIMIT 1",
                            tutor.Estado.Trim());

                        int idCidade = ObterOuCriarCidade(conexao, transacao, tutor.Cidade.Trim(), idEstado);

                        string sqlCep = @"
                            INSERT INTO cep (cep, logradouro, bairro, id_cidade)
                            VALUES (@cep, @logradouro, @bairro, @idCidade)
                            ON DUPLICATE KEY UPDATE
                                logradouro = @logradouro,
                                bairro = @bairro,
                                id_cidade = @idCidade;";

                        using (MySqlCommand comando = new MySqlCommand(sqlCep, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cep", cep);
                            comando.Parameters.AddWithValue("@logradouro", tutor.Logradouro.Trim());
                            comando.Parameters.AddWithValue("@bairro", tutor.Bairro.Trim());
                            comando.Parameters.AddWithValue("@idCidade", idCidade);
                            comando.ExecuteNonQuery();
                        }

                        string sqlEndereco = @"
                            UPDATE endereco
                            SET cep = @cep, numero = @numero
                            WHERE id_endereco = (SELECT id_endereco FROM tutor WHERE id = @id);";

                        using (MySqlCommand comando = new MySqlCommand(sqlEndereco, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cep", cep);
                            comando.Parameters.AddWithValue("@numero", tutor.Numero.ToString());
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            comando.ExecuteNonQuery();
                        }

                        int idMoradia = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_tipo_moradia FROM tipo_moradia WHERE descricao = @descricao",
                            tutor.TipoResidencia);

                        int idOutrosPets = RepositorioGatos.ObterId(
                            conexao, transacao,
                            "SELECT id_opcao FROM opcao_outros_animais WHERE descricao = @descricao",
                            tutor.OutrosAnimais);

                        string sqlTutor = @"
                            UPDATE tutor
                            SET cpf = @cpf, nome = @nome, telefone = @telefone,
                                data_nascimento = @dataNascimento, email = @email,
                                id_tipo_moradia = @idMoradia, id_outros_pets = @idOutrosPets
                            WHERE id = @id;";

                        using (MySqlCommand comando = new MySqlCommand(sqlTutor, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@cpf", cpf);
                            comando.Parameters.AddWithValue("@nome", tutor.Nome.Trim());
                            comando.Parameters.AddWithValue("@telefone", telefone);
                            comando.Parameters.AddWithValue("@dataNascimento", tutor.DataNascimento.Date);
                            comando.Parameters.AddWithValue("@email", tutor.Email.Trim());
                            comando.Parameters.AddWithValue("@idMoradia", idMoradia);
                            comando.Parameters.AddWithValue("@idOutrosPets", idOutrosPets);
                            comando.Parameters.AddWithValue("@id", tutor.Id);
                            comando.ExecuteNonQuery();
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

        private static int ObterOuCriarCidade(
            MySqlConnection conexao, MySqlTransaction transacao, string nome, int idEstado)
        {
            using (MySqlCommand comando = new MySqlCommand(
                "SELECT id_cidade FROM cidade WHERE nome = @nome AND id_estado = @idEstado LIMIT 1;",
                conexao, transacao))
            {
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@idEstado", idEstado);

                object resultado = comando.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            using (MySqlCommand comando = new MySqlCommand(
                "INSERT INTO cidade (nome, id_estado) VALUES (@nome, @idEstado);",
                conexao, transacao))
            {
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@idEstado", idEstado);
                comando.ExecuteNonQuery();
                return Convert.ToInt32(comando.LastInsertedId);
            }
        }

        private static string ApenasDigitos(string texto)
        {
            return new string((texto ?? "").Where(char.IsDigit).ToArray());
        }
    }
}
