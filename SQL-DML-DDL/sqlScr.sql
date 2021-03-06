CREATE TABLE [dbo].[Category](
	[Id] [int] Primary Key NOT NULL,
	[Title] [nvarchar](max) NOT NULL)

ALTER TABLE [dbo].[Product](
	[Id] [int] Primary Key NOT NULL,
	[CategoryId] [int] Foreign Key(CategoryId) references Category(Id) NOT Null,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [int] NOT NULL)

CREATE TABLE [dbo].[ProductFeature](
	[Id] [int] Primary Key NOT NULL,
	[ProductId] [int] Foreign Key(ProductId) references Product(Id) unique NOT NULL,
	[Feature] [nvarchar](max) NOT NULL)

INSERT INTO [Category] (Id, Title)
VALUES (1, 'Sports');
INSERT INTO [Category] (Id, Title)
VALUES (2, 'Family');

INSERT INTO [Product] (Id, CategoryId, Name, Price)
VALUES (1, 1, 'Porsche', 10000);
INSERT INTO [Product] (Id, CategoryId, Name, Price)
VALUES (2, 1, 'Ferrari', 12000);
INSERT INTO [Product] (Id, CategoryId, Name, Price)
VALUES (3, 2, 'Toyota', 2000);

INSERT INTO [ProductFeature] (Id, ProductId, Feature)
VALUES (1, 1, 'Opening Roof');
INSERT INTO [ProductFeature] (Id, ProductId, Feature)
VALUES (2, 2, 'Red Paint');
INSERT INTO [ProductFeature] (Id, ProductId, Feature)
VALUES (3, 3, 'Huge Storage');

Use [carsdb]
SELECT * FROM Product;
SELECT * FROM Product WHERE CategoryId = 1
