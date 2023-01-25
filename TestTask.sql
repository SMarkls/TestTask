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
('���'), --1
('���. ������'), --2
('�����������'), --3
('������� �������'), --4
('����������'); --5

INSERT INTO Products(Title) VALUES
('����'), --���							   			    1
('��������� �����'), --���							    2
('������� ����'), --���, ���.������					    3
('����'), --���. ������								    4
('��-�� ��� ����� ������'), --���. ������			    5
('������� �������'), --�����������					    6
('�����������'), --������� �������					    7
('������������� ������'), --������� �������, ����������	8
('������'), --����������								9
('�������� �������'); --��� ���������					10

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


SELECT Products.Title as '�����', Categories.Title as '���������'
FROM Products
LEFT JOIN ProductCategories
	ON ProductCategories.ProductId = Products.Id
LEFT JOIN Categories
	ON ProductCategories.CategoryId = Categories.Id;