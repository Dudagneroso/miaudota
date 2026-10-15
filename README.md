# 🐱 Miaudota

Sistema de gestão de adoção de gatos desenvolvido para a ONG **Projeto Mundo Felino**. Projeto de extensão do curso de Análise e Desenvolvimento de Sistemas do IFSP Campinas.

O Miaudota ajuda a ONG a organizar os gatos disponíveis para adoção, cadastrar tutores e vincular cada adoção ao gato escolhido.

## 📌 Sobre o projeto

A ONG precisa de uma forma simples de consultar os gatos acolhidos, saber há quanto tempo cada um está na ONG e registrar quem adotou. O Miaudota reúne tudo isso em uma aplicação desktop com navegação por menu lateral.

## ✨ Funcionalidades

- [x] Tela de login
- [x] Menu lateral para navegar entre as telas
- [x] Tela inicial com cards dos gatos (foto, nome, microchip, idade, sexo e pelagem)
- [x] Consulta de gatos em tabela, com campo de pesquisa
- [x] Cadastro de gatos, com upload de foto
- [x] Cadastro de tutores, com tabela de gatos disponíveis e seleção do gato adotado
- [ ] Filtros da tela inicial (mais recentes, mais tempo na ONG e idade)
- [ ] Vínculo completo entre tutor e gato adotado
- [ ] Banco de dados (hoje os dados vêm de uma lista de teste em memória)

## 🛠️ Tecnologias

- C#
- Windows Forms (.NET Framework)
- Visual Studio
- Git e GitHub

## 📁 Estrutura do projeto

```
miaudota/
├── Dados/        Fonte de dados (repositório de teste)
├── Models/       Classes que representam os dados (ex: Gato)
├── Telas/        Forms e UserControls (login, consulta, cadastros)
├── Resources/    Imagens e recursos
├── Properties/
└── Program.cs    Ponto de entrada da aplicação
```

## ▶️ Como executar

**Pré-requisitos:** Windows e Visual Studio com a carga de trabalho **Desenvolvimento para desktop com .NET** instalada.

1. Clone o repositório:
   ```bash
   git clone https://github.com/Dudagneroso/miaudota.git
   ```
2. Abra o arquivo `miaudota.slnx` no Visual Studio.
3. Pressione **F5** para compilar e executar.

**Login de teste (provisório):** usuário `admin` e senha `admin`.

## 👥 Equipe

- Maria Eduarda Santos Generoso
- Júlia Modesto
- Lívia André

## 🚧 Status

Projeto em desenvolvimento.
