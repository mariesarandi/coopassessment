-- Create a new database called 'ProductsDB'
CREATE DATABASE ProductsDB
GO
USE ProductsDB

-- Create a new table called '[Product]' in schema '[dbo]'
CREATE TABLE [dbo].[Product]
(
    [ID] INT PRIMARY KEY IDENTITY (1,1), -- Primary Key column
    [Name] VARCHAR(50) NOT NULL,
    [Price] DECIMAL (38,2) NOT NULL,
    [Description] VARCHAR(50) NOT NULL
);
GO

-- Insert rows into table 'Product' in schema '[dbo]'
INSERT INTO [dbo].[Product]
( -- Columns to insert data into
 [Name], [Price], [Description]
)
VALUES
( -- First row: values for the columns in the list above
 'Dog Shampoo', 10.57, 'shampoo for long hair dogs'
),
( -- Second row: values for the columns in the list above
 'WD Red 4 TB', 150.99, 'NAS hard drive'
),
(-- Third row: values for the columns in the list above
'2018 Nissan Mourano', 37866.99, 'Nissan Mourano AWD with Tech Package?'
)

GO

-- Select rows from a Table or View '[Product]' in schema '[dbo]'
SELECT * INTO [dbo].[Product_Copy]
FROM [dbo].[Product]
GO

-- Delete rows from table '[Product_Copy]' in schema '[dbo]'
DELETE FROM [dbo].[Product_Copy]
WHERE ID = 2
GO

