CREATE TABLE Managers
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE Employees
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);
Go

CREATE TABLE Categories
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
);
Go

CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Price MONEY NOT NULL DEFAULT(0),
    CategoryId INT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories (Id)
);
GO

CREATE TABLE Spices
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
)

INSERT INTO Managers
    (Name, Email, Password)
VALUES
    ('بشير السمان', 'Basheer@gmail.com', 'password1'),
    ('منذر الرفاعي', 'Monzer@gmail.com', 'password2'),
    ('محمد جندلي', 'Mohammmad@gmail.com', 'password3');
    

    INSERT INTO Categories
    (Name)
VALUES
    ('منظفات'),
    ('معلبات'),
    ('البان وأجبان'),
    ('بهارات');

