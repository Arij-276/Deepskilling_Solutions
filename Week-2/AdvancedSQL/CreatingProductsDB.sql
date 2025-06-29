SELECT * FROM Products;

CREATE DATABASE IF NOT EXISTS ShopDB;
USE ShopDB;

DROP TABLE IF EXISTS Products;

CREATE TABLE Products 
(
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductName, Category, Price) VALUES 
('iPhone', 'Electronics', 999.00),
('Samsung TV', 'Electronics', 800.00),
('MacBook', 'Electronics', 1299.00),
('HP Laptop', 'Electronics', 999.00),
('Dell Monitor', 'Electronics', 300.00),
('Nike Shoes', 'Apparel', 150.00),
('Adidas Shoes', 'Apparel', 150.00),
('Puma Shirt', 'Apparel', 50.00),
('Levi Jeans', 'Apparel', 80.00),
('Zara Jacket', 'Apparel', 120.00);

SELECT * FROM products;