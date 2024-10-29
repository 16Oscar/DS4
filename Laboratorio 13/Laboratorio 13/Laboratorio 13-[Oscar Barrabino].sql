/*Ejemplo 1*/ 
Select * from Products

/*Ejemplo 2*/ 
Select ProductID, ProductName, UnitPrice from Products

/*Ejemplo 3*/ 
Select ProductID, ProductName, UnitPrice 
from Products
Where UnitPrice > 15 

/*Ejemplo 4*/
Select ProductID, ProductName, UnitPrice 
from Products
Where UnitPrice >= 15 and UnitPrice <= 50

/*Ejemplo 5*/
Select ProductID, ProductName, UnitPrice 
from Products
Where UnitPrice between 15 and 50

/*Ejemplo 6*/
Select ProductID, ProductName, UnitPrice 
from Products
Where Not UnitPrice > 15

/*Ejemplo 7*/
Select ProductID, ProductName, UnitPrice 
from Products
Where ProductID > 15 or UnitPrice < 10

/*Ejemplo 8*/
Select EmployeeID, LastName From Employees
Where LastName like 'D%'

/*Ejemplo 9*/
Select EmployeeID, LastName From Employees
Where LastName like '%N'

/*Ejemplo 10*/
Select EmployeeID, LastName From Employees
Where Title like '%SALES%'

/*Ejemplo 11*/
Select EmployeeID, LastName From Employees
Where LastName Not like 'D%'

/*Ejemplo 12*/
Select ProductID, ProductName, UnitPrice 
From Products
Order by ProductID ASC

/*Ejemplo 13*/
Select ProductID, ProductName, UnitPrice 
From Products
Order by ProductID DESC

/*Ejemplo 14*/
Select Distinct OrderID From [Order Details]

/*Ejemplo 15*/
Select Top 5 OrderID, ProductID, Quantity
From [Order Details]

/*Ejemplo 16*/
Select Top 10 Percent OrderID, ProductID, Quantity
From [Order Details]

/*Ejemplo 17*/
Select CategoryName As [Nombre de Categoria]
From Categories

/*Ejemplo 18*/
Select OrderID, OrderDate, ShippedDate + 5 AS RetrasoEnvio
From Orders

/*Ejemplo 19*/
Select OrderID, P.ProductID, ProductName
From Products P
Inner Join [Order Details] OD
ON P.ProductID = OD.ProductID

/*Ejemplo 20*/
Select ProductName, CompanyName, ContactName
From Products P
Full Join Suppliers S
ON P.SupplierID = S.SupplierID