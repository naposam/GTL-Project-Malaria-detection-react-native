create table Mathematics
(
StudentID int not null primary key,
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table Integrated_Science
(
Integid int references Mathematics(StudentID) ,
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table English_Language
(
eid int references Mathematics(StudentID),
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table Social_Studies
(
socid int references Mathematics(StudentID),
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table Biology
(
BioID int references Mathematics(StudentID),
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table Chemistry
(
chemicID int references Mathematics(StudentID),
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
create table History
(
HisroyID int references Mathematics(StudentID),
RawAssessmentScore float,
TotalRawAssessment float,
TotalAssessmentScore float,
ExamsScore  float,
Total_Exams_Score float,
Total_Score float,
Grade varchar(50),
Subject varchar(50)
)
