﻿create table StudentReg
(
StudentID int  references Mathematics(StudentID),
FirstName NVarchar(50),
MiddleName NVarchar(50),
LastName Nvarchar(50),
Address Nvarchar(50),
DOB date,
Gender Nvarchar(50),
Year Varchar(50),
Picture image
)