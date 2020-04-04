IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Siatis] (
    [Id] uniqueidentifier NOT NULL,
    [Resolvido] bit NOT NULL,
    [Resolucao] varchar(500) NOT NULL,
    [NumeroProcesso] varchar(100) NOT NULL,
    [DataCriacaoProcesso] datetime2 NOT NULL,
    [TipoProcesso] varchar(100) NOT NULL,
    [NomeProcesso] varchar(100) NOT NULL,
    [NomeUser] varchar(100) NOT NULL,
    CONSTRAINT [PK_Siatis] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200330073415_Initial', N'3.1.2');

GO

