USE [BookShop]
GO

DELETE FROM BooksToAuthors
DELETE FROM Books
DELETE FROM Authors
DELETE FROM Publishers

INSERT INTO Authors (Name) VALUES ('Endrew Troelsen')
INSERT INTO Authors (Name) VALUES ('Matthew MacDonald')
INSERT INTO Authors (Name) VALUES ('Mario Szpuszta')
INSERT INTO Authors (Name) VALUES ('Eugene Kartsev')

INSERT INTO Publishers (Name) VALUES ('Apress')
INSERT INTO Publishers (Name) VALUES ('Williamspublishing')
INSERT INTO Publishers (Name) VALUES ('WROX')

INSERT INTO Books (Name, Description, IdPublisher, Price, PublishedAt)
VALUES ('Pro ASP.NET 3.5 in C#2008', '', (SELECT Id FROM Publishers WHERE Name='Apress'), '350.9900', GETDATE())
INSERT INTO Books (Name, Description, IdPublisher, Price, PublishedAt)
VALUES ('Another Interesting Book about .NET', '', (SELECT Id FROM Publishers WHERE Name='WROX'), '199.10', GETDATE())
INSERT INTO Books (Name, Description, IdPublisher, Price, PublishedAt)
VALUES ('Silverlight 2.0', '', (SELECT Id FROM Publishers WHERE Name='Williamspublishing'), '230.50', GETDATE())
INSERT INTO Books (Name, Description, IdPublisher, Price, PublishedAt)
VALUES ('Mu-mu, the beginning', '', (SELECT Id FROM Publishers WHERE Name='Apress'), '1.99', GETDATE())

INSERT INTO BooksToAuthors (IdBook, IdAuthor)
VALUES ((SELECT Id FROM Books WHERE Name='Pro ASP.NET 3.5 in C#2008'), (SELECT Id FROM Authors WHERE Name='Matthew MacDonald'))
INSERT INTO BooksToAuthors (IdBook, IdAuthor)
VALUES ((SELECT Id FROM Books WHERE Name='Pro ASP.NET 3.5 in C#2008'), (SELECT Id FROM Authors WHERE Name='Mario Szpuszta'))
INSERT INTO BooksToAuthors (IdBook, IdAuthor)
VALUES ((SELECT Id FROM Books WHERE Name='Another Interesting Book about .NET'), (SELECT Id FROM Authors WHERE Name='Endrew Troelsen'))
INSERT INTO BooksToAuthors (IdBook, IdAuthor)
VALUES ((SELECT Id FROM Books WHERE Name='Silverlight 2.0'), (SELECT Id FROM Authors WHERE Name='Matthew MacDonald'))
INSERT INTO BooksToAuthors (IdBook, IdAuthor)
VALUES ((SELECT Id FROM Books WHERE Name='Mu-mu, the beginning'), (SELECT Id FROM Authors WHERE Name='Eugene Kartsev'))