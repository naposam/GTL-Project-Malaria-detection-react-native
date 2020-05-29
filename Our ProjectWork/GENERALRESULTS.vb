Imports System.Data.SqlClient


Public Class GENERALRESULTS
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub GENERALRESULTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
            Dim da = New DataTable()


            Dim sda = New SqlDataAdapter("Select  Mathematics.StudentID,Mathematics.Subject,Mathematics.RawAssessmentScore,Mathematics.TotalRawAssessment,Mathematics.TotalAssessmentScore,Mathematics.ExamsScore,Mathematics.Total_Exams_Score,Mathematics.Total_Score,Mathematics.Grade, Integrated_Science.Subject ,Integrated_Science.RawAssessmentScore,Integrated_Science.TotalRawAssessment,Integrated_Science.TotalAssessmentScore,Integrated_Science.ExamsScore,Integrated_Science.Total_Exams_Score,Integrated_Science.Total_Score,Integrated_Science.GRADE,English_Language.Subject,English_Language.RawAssessmentScore,English_Language.TotalRawAssessment,English_Language.TotalAssessmentScore,English_Language.ExamsScore,English_Language.Total_Exams_Score,English_Language.Total_Score,English_Language.Grade,Biology.Subject,Biology.RawAssessmentScore,Biology.TotalRawAssessment,Biology.TotalAssessmentScore,Biology.ExamsScore,Biology.Total_Exams_Score,Biology.Total_Score,Biology.Grade, History.Subject,History.RawAssessmentScore,History.TotalRawAssessment,History.TotalAssessmentScore,History.ExamsScore,History.Total_Exams_Score,History.Total_Score,History.Grade,Chemistry.Subject,Chemistry.RawAssessmentScore,Chemistry.TotalRawAssessment,Chemistry.TotalAssessmentScore,Chemistry.ExamsScore,Chemistry.Total_Exams_Score,Chemistry.Total_Score,Chemistry.Grade,Social_Studies.Subject,Social_Studies.RawAssessmentScore,Social_Studies.TotalRawAssessment,Social_Studies.TotalAssessmentScore,Social_Studies.ExamsScore,Social_Studies.Total_Exams_Score,Social_Studies.Total_Score,Social_Studies.Grade from Mathematics LEFT OUTER  JOIN Integrated_Science on Mathematics.StudentID =  Integrated_Science.Integid LEFT OUTER  JOIN English_Language on Mathematics.StudentID=English_Language.eid LEFT OUTER  JOIN Biology on Mathematics.StudentID=Biology.BioID LEFT OUTER  JOIN History on Mathematics.StudentID=History.HisroyID LEFT OUTER  JOIN Chemistry on Mathematics.StudentID=Chemistry.ChemicID LEFT OUTER  JOIN Social_Studies on Mathematics.StudentID=Social_Studies.socid  ", con)
            sda.Fill(da)
            DataGridView1.DataSource = da
           
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Public Sub FilterData(valueToSearch As String)
    '    con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


    '    Dim SearchQuary As String = "SELECT * FROM Mathematics,Chemistry,Biology,English_language,Social_Studies,History,Integrated_Science WHERE CONCAT(StudentID,HisroyID,eid,BioID,ChemicID,socid,Integid  ) like '%" & valueToSearch & "%'"


    '    Dim cmd As New SqlCommand(SearchQuary, con)
    '    Dim Adapter As New SqlDataAdapter(cmd)
    '    Dim table As New DataTable()
    '    Adapter.Fill(table)
    '    DataGridView1.DataSource = table
    '    DataGridView1.Refresh()

    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'FilterData(TextBox1.Text)
        'DataGridView1.Refresh()
    End Sub

    Private Sub Button1_TextChanged(sender As Object, e As EventArgs) Handles Button1.TextChanged
        'FilterData(TextBox1.Text)
        'DataGridView1.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class