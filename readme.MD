#0 Criar o projeto

#1 Modelagem de dados
    ID_Cliente INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Endereco VARCHAR (255),
    Telefone VARCHAR(20),
    RG VARCHAR (20),
    CPF VARCHAR (20),
    Email VARCHAR (255),

#2 Criar um banco de dados 
    CREATE DATABASE ClienteDb;
    USE ClienteDb;
    CREATE TABLE Cliente (
        ID_Cliente INT AUTO_INCREMENT PRIMARY KEY,
        Nome VARCHAR(255) NOT NULL,
        Endereco VARCHAR (255),
        Telefone VARCHAR (20),
        RG VARCHAR (20),
        CPF VARCHAR (20),
        Email VARCHAR (255)
    );

#3 Configuracao do Banco de dados
    Adicionar pacotes do Entity Framework Core:

    dotnet add package Pomelo.EntityFrameworjCore.MySql --version 5.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.0

#4 Configurar a string de conexao
    Edite o arquivo appsettings.json para incluir a string de conexao ao seu banco de dados MySQL.

    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Database=clientedb;User=root;Password=;""
        }
        "logging": {
            "LogLevel": {
                "Default": "Information",
                "Microsoft.AspNetCore": "Warning"
            }
        },
        "AllowedHosts": "*"
    }

#5 Criar a classe de contexto de banco de dados

    Data/ApplicationDbContext.cs

#6 Criar a classe modeladora
    Models/Cliente.cs

#7 Criar o Controlador
    Controllers/ClientesController.cs

#8 Criar as Visualizacoes
    Views/Home/Index.cshtml
    Views/Home/Create.cshtml
    Views/Home/Deteils.cshtml
    Views/Home/Edit.cshtml
    Views/Home/Delete.cshtml
    
    