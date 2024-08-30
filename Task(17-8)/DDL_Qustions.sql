--Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).--
create table dbo.Employees(
id int NOT NULL, 
Empname varchar(50),
salary decimal(6,2))

--•	Add a new column named "Department" to the "Employees" table with data type varchar(50).--
alter table dbo.Employees
add department varchar(50)

--•	Remove the "Salary" column from the "Employees" table.--
alter table dbo.Employees
drop column salary

--•	Rename the "Department" column in the "Employees" table to "DeptName".--
EXEC sp_rename 'dbo.Employees.department', 'DeptName', 'column'

--•	Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).--
create table dbo.Projects(
projectid int primary key identity(1,1),
projectname varchar(80)
)

--•	Add a primary key constraint to the "Employees" table for the "ID" column.--
alter table dbo.Employees
add constraint pk_employeesId primary key (id)

--•	Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").--
alter table dbo.Employees
add constraint fk_EmpProj foreign key (id) references Projects(projectid)

--•	Remove the foreign key relationship between "Employees" and "Projects."--
alter table dbo.Employees drop constraint fk_EmpProj

--•	Add a unique constraint to the "Name" column in the "Employees" table.--
alter table dbo.Employees add unique (Empname)

--•	Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).--
create table dbo.Customers(
customerId int ,
firstName varchar(20),
lastName varchar(20),
email varchar(20),
customerStatus varchar,
primary key(customerId))

--•	Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.--
alter table dbo.Customers
add unique (firstName, lastName)

--•	Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted.--
alter table dbo.Customers
add constraint CustomStat default 'Active' for customerStatus

--•	Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).--
create table dbo.Orders(
orderId int ,
customerID int,
orderDate date,
totalAmount decimal(6,2),
primary key(orderId),
constraint fk_OrderCustom foreign key (customerID) references Customers(customerId) on delete cascade

)

--•	Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.--
alter table dbo.Orders
add constraint check_Con check(totalAmount > 0)

--•	Create a schema named "Sales" and move the "Orders" table into this schema.--
create schema Sales
ALTER SCHEMA Sales TRANSFER OBJECT::dbo.Orders  

--•	Rename the "Orders" table to "SalesOrders."--
EXEC sp_rename 'Sales.Orders', 'Sales.SalesOrders'
