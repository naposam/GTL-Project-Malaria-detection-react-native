﻿create table data1
(
STID int primary key,
ASSESSMENT_ONE NVARCHAR(50),
ASSESSMENT_TWO NVARCHAR(50),
TOTAL_ASSESSMENT NVARCHAR(50),
EXAMS_SCORE NVARCHAR(50),
TOTAL_SCORE NVARCHAR(50)

);
create table datat2
(
GRADE NVARCHAR(50),
SUBJECT NVARCHAR(50),
 SID INT REFERENCES data1(STID)
);