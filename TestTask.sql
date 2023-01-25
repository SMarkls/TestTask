DROP TABLE IF EXISTS ProductCategories;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;


CREATE TABLE Categories (
Id INT PRIMARY KEY IDENTITY(1, 1),
Title NVARCHAR(50) NOT NULL
);

CREATE TABLE Products (
Id INT PRIMARY KEY IDENTITY(1, 1),
Title NVARCHAR(50) NOT NULL
);

CREATE TABLE ProductCategories ( 
ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO Categories(Title) VALUES
('Еда'), --1
('Хоз. Товары'), --2
('Развлечения'), --3
('Бытовая техника'), --4
('Сантехника'); --5

INSERT INTO Products(Title) VALUES
('Хлеб'), --еда							   			    1
('Сливочное масло'), --еда							    2
('Пищевая сода'), --еда, хоз.товары					    3
('Мыло'), --хоз. товары								    4
('Ср-Во для мытья посуды'), --хоз. товары			    5
('Детская игрушка'), --развлечения					    6
('Холодильник'), --бытовая техника					    7
('Посудомоечная машина'), --бытовая техника, сантехника	8
('Унитаз'), --сантехника								9
('Походная палатка'); --без категории					10

INSERT INTO ProductCategories (ProductId, CategoryId) VALUES
(1, 1),
(2, 1),
(3, 1),
(3, 2),
(4, 2),
(5, 2),
(6, 3),
(7, 4),
(8, 4),
(9, 5);

INSERT INTO ProductCategories (ProductId) VALUES (10);


SELECT Products.Title as 'Товар', Categories.Title as 'Категория'
FROM Products
LEFT JOIN ProductCategories
	ON ProductCategories.ProductId = Products.Id
LEFT JOIN Categories
	ON ProductCategories.CategoryId = Categories.Id;