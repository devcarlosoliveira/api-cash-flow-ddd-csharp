## Sobre o projeto: Cash Flow

Esta **API**, desenvolvida com **.NET 8**, incorpora os princípios do **Domain-Driven Design (DDD)**, proporcionando uma solução estruturada e eficaz para o gerenciamento de despesas pessoais. Seu principal objetivo é permitir que os usuários registrem suas despesas, detalhando informações como título, data e hora, descrição, valor e tipo de pagamento, com os dados armazenados de forma segura em um banco de dados **SQLite**.

A arquitetura da **API** é baseada em **REST**, utilizando métodos **HTTP** padrão para garantir uma comunicação eficiente e simplificada. Complementando essa estrutura, a documentação **Swagger** oferece uma interface gráfica interativa, permitindo que os desenvolvedores explorem e testem os endpoints de maneira intuitiva.

Entre os pacotes NuGet utilizados, o **AutoMapper** se destaca por facilitar o mapeamento entre objetos de domínio e as requisições/respostas, minimizando a necessidade de código repetitivo. O **FluentAssertions** é empregado nos testes de unidade, tornando as verificações mais legíveis e contribuindo para a criação de testes claros e compreensíveis. Para as validações, o **FluentValidation** é utilizado para implementar regras de forma simples e intuitiva nas classes de requisições, mantendo o código limpo e de fácil manutenção. Por fim, o **Entity Framework** atua como um ORM (Object-Relational Mapper), simplificando as interações com o banco de dados e permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de escrever consultas SQL.

![hero-image]

### Features

- **Domain-Driven Design (DDD)**: Estrutura modular que facilita o entendimento e a manutenção do domínio da aplicação.
- **Testes de Unidade**: Testes abrangentes com FluentAssertions para garantir a funcionalidade e a qualidade.
- **Geração de Relatórios**: Capacidade de exportar relatórios detalhados para **PDF e Excel**, oferecendo uma análise visual e eficaz das despesas.
- **RESTful API com Documentação Swagger**: Interface documentada que facilita a integração e o teste por parte dos desenvolvedores.

### Construído com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-sqlite]
![badge-swagger]

## Getting Started

Para obter uma cópia local funcionando, siga estes passos.

### Requisitos

* Visual Studio versão 2022+ ou Visual Studio Code
* Windows 10+ ou Linux/MacOS com [.NET SDK][dot-net-sdk] instalado

### Instalação

1. Clone o repositório:
    ```sh
    git clone https://github.com/devcarlosoliveira/api-cash-flow-ddd-csharp.git
    ```

2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)



<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Images -->
[hero-image]: images/heroimage.png

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-sqlite]: https://img.shields.io/badge/SQLite-4479A1?logo=sqlite&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge