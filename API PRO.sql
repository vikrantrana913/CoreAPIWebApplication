Create database Texas
Use Texas

Create table Employee
(
EmpId bigint primary key identity(1,1),
Name nvarchar(50),
Email nvarchar(50)
)

Select * from Employee

Create Procedure GetEmployeeData
as
begin
Select * from Employee
End

insert into Employee(Name,Email)values('Rama','rama2@gmail.com')

Exec GetEmployeeData