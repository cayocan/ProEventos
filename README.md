# ProEventos

ProEventos é uma aplicação completa para gerenciamento de eventos, composta por um backend em .NET e um frontend em Angular. O sistema permite o cadastro, edição, exclusão e visualização de eventos, além de funcionalidades para gerenciamento de palestrantes, lotes, redes sociais e usuários.

## Sumário

- [ProEventos](#proeventos)
  - [Sumário](#sumário)
  - [Funcionalidades](#funcionalidades)
  - [Tecnologias Utilizadas](#tecnologias-utilizadas)
    - [Backend (.NET)](#backend-net)
    - [Frontend (Angular)](#frontend-angular)
  - [Como Executar o Projeto](#como-executar-o-projeto)
    - [Pré-requisitos](#pré-requisitos)
    - [Backend](#backend)
    - [Frontend](#frontend)
  - [Estrutura do Projeto](#estrutura-do-projeto)
  - [Contribuição](#contribuição)
  - [Licença](#licença)

---

## Funcionalidades

- Cadastro, edição e exclusão de eventos
- Gerenciamento de palestrantes
- Controle de lotes de ingressos
- Integração com redes sociais dos eventos
- Autenticação e autorização de usuários
- Upload de imagens para eventos e palestrantes
- Interface web responsiva

## Tecnologias Utilizadas

### Backend (.NET)

- ASP.NET Core
- Entity Framework Core
- SQL Server
- AutoMapper
- JWT Authentication

### Frontend (Angular)

- Angular
- Angular Material
- RxJS
- Bootstrap

## Como Executar o Projeto

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- SQL Server

### Backend

```bash
cd ProEventos.API
dotnet restore
dotnet ef database update
dotnet run
```

A API estará disponível em `https://localhost:5001`.

### Frontend

```bash
cd ProEventos-App
npm install
ng serve
```

A aplicação estará disponível em `http://localhost:4200`.

## Estrutura do Projeto

```
/ProEventos
    /ProEventos.API      # Backend .NET
    /ProEventos-App      # Frontend Angular
    /README.md
```

## Contribuição

1. Fork este repositório
2. Crie uma branch: `git checkout -b minha-feature`
3. Faça commit das suas alterações: `git commit -m 'Minha nova feature'`
4. Push para o branch: `git push origin minha-feature`
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a licença MIT.

---