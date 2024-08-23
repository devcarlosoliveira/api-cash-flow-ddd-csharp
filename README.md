## Sobre o projeto: Cash Flow

Esta **API**, desenvolvida com **.NET 8**, incorpora os princ�pios do **Domain-Driven Design (DDD)**, proporcionando uma solu��o estruturada e eficaz para o gerenciamento de despesas pessoais. Seu principal objetivo � permitir que os usu�rios registrem suas despesas, detalhando informa��es como t�tulo, data e hora, descri��o, valor e tipo de pagamento, com os dados armazenados de forma segura em um banco de dados **SQLite**.

A arquitetura da **API** � baseada em **REST**, utilizando m�todos **HTTP** padr�o para garantir uma comunica��o eficiente e simplificada. Complementando essa estrutura, a documenta��o **Swagger** oferece uma interface gr�fica interativa, permitindo que os desenvolvedores explorem e testem os endpoints de maneira intuitiva.

Entre os pacotes NuGet utilizados, o **AutoMapper** se destaca por facilitar o mapeamento entre objetos de dom�nio e as requisi��es/respostas, minimizando a necessidade de c�digo repetitivo. O **FluentAssertions** � empregado nos testes de unidade, tornando as verifica��es mais leg�veis e contribuindo para a cria��o de testes claros e compreens�veis. Para as valida��es, o **FluentValidation** � utilizado para implementar regras de forma simples e intuitiva nas classes de requisi��es, mantendo o c�digo limpo e de f�cil manuten��o. Por fim, o **Entity Framework** atua como um ORM (Object-Relational Mapper), simplificando as intera��es com o banco de dados e permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de escrever consultas SQL.

![hero-image]

### Features

- **Domain-Driven Design (DDD)**: Estrutura modular que facilita o entendimento e a manuten��o do dom�nio da aplica��o.
- **Testes de Unidade**: Testes abrangentes com FluentAssertions para garantir a funcionalidade e a qualidade.
- **Gera��o de Relat�rios**: Capacidade de exportar relat�rios detalhados para **PDF e Excel**, oferecendo uma an�lise visual e eficaz das despesas.
- **RESTful API com Documenta��o Swagger**: Interface documentada que facilita a integra��o e o teste por parte dos desenvolvedores.

### Constru�do com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-sqlite]
![badge-swagger]

## Getting Started

Para obter uma c�pia local funcionando, siga estes passos.

### Requisitos

* Visual Studio vers�o 2022+ ou Visual Studio Code
* Windows 10+ ou Linux/MacOS com [.NET SDK][dot-net-sdk] instalado

### Instala��o

1. Clone o reposit�rio:
    ```sh
    git clone https://github.com/devcarlosoliveira/api-cash-flow-ddd-csharp.git
    ```

2. Preencha as informa��es no arquivo `appsettings.Development.json`.
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