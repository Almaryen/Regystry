USE [master]
GO

IF EXISTS(SELECT 1 FROM sys.databases WHERE name='BookShop')
	DROP DATABASE [BookShop]
	
CREATE DATABASE [BookShop]
GO

USE [BookShop]
GO

CREATE TABLE [Authors]
(
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(150) NULL
)
GO

CREATE TABLE [Books]
(
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(250) NOT NULL,
	Description nvarchar(500) NULL,
	IdPublisher int NOT NULL,
	Price float NOT NULL,
	PublishedAt datetime NOT NULL
)
GO

CREATE TABLE [BooksToAuthors]
(
	IdBook int NOT NULL,
	IdAuthor int NOT NULL
)
GO

CREATE TABLE [Publishers]
(
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(150) NOT NULL
)
GO


ALTER TABLE Authors ADD CONSTRAINT PK_Authors
PRIMARY KEY (Id)
GO
ALTER TABLE Books ADD CONSTRAINT PK_Books
PRIMARY KEY (Id)
GO
ALTER TABLE BooksToAuthors ADD CONSTRAINT PK_BooksToAuthors
PRIMARY KEY (IdBook,IdAuthor)
GO
ALTER TABLE Publishers ADD CONSTRAINT PK_Publishers
PRIMARY KEY (Id)
GO

ALTER TABLE Books ADD CONSTRAINT FK_Books_Publishers
FOREIGN KEY (IdPublisher) REFERENCES Publishers(Id)
GO

ALTER TABLE BooksToAuthors ADD CONSTRAINT FK_BooksToAuthors_Books
FOREIGN KEY (IdBook) REFERENCES Books(Id)
GO

ALTER TABLE BooksToAuthors ADD CONSTRAINT FK_BooksToAuthors_Author
FOREIGN KEY (IdAuthor) REFERENCES Authors(Id)
GO