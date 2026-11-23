# Miaudota

Sistema desktop para gestão de adoção de gatos, desenvolvido como projeto de extensão do curso de Análise e Desenvolvimento de Sistemas (IFSP Campinas). O Miaudota organiza o cadastro de gatos, tutores, lares temporários e ocorrências, e acompanha a situação de cada animal desde a chegada à ONG até a adoção.

## Funcionalidades

- **Gatos:** cadastro com foto, microchip, características, saúde, vacinas, testes de FIV e FeLV e local de resgate marcado no mapa. Consulta, edição e exclusão com confirmação.
- **Tutores:** cadastro com endereço, tipo de moradia e outros animais. O cadastro já registra a adoção do gato escolhido. Só são aceitos tutores com 18 anos ou mais.
- **Lares temporários:** cadastro com endereço, tipo de moradia, capacidade, disponibilidade e data de início. Lares sem vagas não aparecem como opção no cadastro de gatos.
- **Ocorrências:** registro de devolução, internação, fuga, abandono, retorno ao lar e óbito, com histórico por gato.
- **Dashboards:** indicadores de gatos, lares e vagas disponíveis.
- **Mapa:** marcação e visualização do local de resgate de cada gato.

## Regras de negócio

- Uma devolução remove o vínculo do gato com o tutor e volta o status para Disponível.
- Uma internação muda o status do gato para Internado.
- Quando um gato é adotado, ele é desvinculado do lar temporário e a vaga volta a ficar disponível.
- Um gato só pode ser adotado se ainda estiver com o status Disponível.
- O CPF do tutor e do lar não pode se repetir.

## Tecnologias

- C# com Windows Forms (.NET Framework)
- MySQL, acessado com ADO.NET (MySql.Data)
- WebView2 com Leaflet e OpenStreetMap para o mapa
- Newtonsoft.Json

## Arquitetura

O código é organizado em camadas simples, separadas por pasta:

| Pasta | Conteúdo |
|-------|----------|
| `Telas` | Formulários e UserControls da interface |
| `Models` | Classes de domínio (Gato, Tutor, LarTemporario, OcorrenciaGato) com validações |
| `Dados` | Repositórios que acessam o MySQL (RepositorioGatos, RepositorioTutores, RepositorioLaresTemporarios, RepositorioOcorrencia) |
| `Funcoes` | Funções auxiliares |
| `Mapa` | Página `mapa.html` carregada pelo WebView2 |

### Cache de cadastros

Para reduzir idas ao banco, gatos, lares e ocorrências cadastrados ficam em um cache em memória (limite de 5 registros). A sincronização com o MySQL acontece em três momentos:

1. Quando o cache atinge 5 registros.
2. Ao abrir qualquer tela de consulta.
3. Ao fechar o sistema.

A gravação do lote é feita em uma transação: se um registro falhar, nenhum do lote é gravado e todos continuam no cache.

## Banco de dados

O modelo segue a terceira forma normal e tem 23 tabelas, entre elas `gato`, `tutor`, `lar_temporario`, `adocao`, `ocorrencia`, `gato_vacina`, `local_resgate`, `usuario` e as tabelas de domínio (pelagem, coloração, status, tipo de moradia, capacidade, entre outras). O endereço é separado em `endereco`, `cep`, `cidade` e `estado`.

O script completo, com as tabelas e os dados iniciais, está em `SQLMiaudota.sql`.

## Como executar

### Pré-requisitos

- Windows
- Visual Studio com a carga de trabalho de desenvolvimento para desktop com .NET
- MySQL Server
- WebView2 Runtime (já vem instalado no Windows 11 e em versões atualizadas do Windows 10)
- Conexão com a internet, necessária para carregar o mapa

### Passo a passo

1. Clone o repositório:

   ```bash
   git clone https://github.com/SEU-USUARIO/miaudota.git
   ```

2. Crie o banco executando o script `SQLMiaudota.sql` no MySQL Workbench ou pelo terminal. Atenção: o script começa apagando o banco `miaudota`, caso ele já exista.
3. Abra a solução no Visual Studio e restaure os pacotes NuGet (MySql.Data, Newtonsoft.Json e Microsoft.Web.WebView2).
4. Ajuste a string de conexão na classe `Conexao` com o servidor, o usuário e a senha do seu MySQL.
5. Execute o projeto com F5.

## Próximos passos

- Conexão com leitor de microchip
- Preenchimento de endereço pela API do ViaCEP
- Tela de gerenciamento de usuários e senhas para o perfil de administrador
- Edição e exclusão de lares temporários e de ocorrências
- Novos dashboards

## Autoria

Desenvolvido por Maria Eduarda Santos Generoso, estudante de Análise e Desenvolvimento de Sistemas no IFSP Campinas.
