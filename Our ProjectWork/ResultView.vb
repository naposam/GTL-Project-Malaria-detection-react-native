Imports System.Data.SqlClient
Public Class ResultView
    Dim con As SqlConnection
    Dim cmd As SqlCommand
   

    Private Sub ResultView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
        Me.ScoretableTableAdapter.Fill(Me.SCHOOLDataSet2.Scoretable)

    End Sub
    Public Sub FilterData(valueToSearch As String)
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Dim SearchQuary As String = "SELECT * FROM Scoretable WHERE CONCAT(STID,ASSESSMENT_ONE,ASSESSMENT_TWO,TOTAL_ASSESSMENT,EXAMS_SCORE,TOTAL_SCORE,GRADE,SUBJECT) like '%" & valueToSearch & "%'"


        Dim cmd As New SqlCommand(SearchQuary, con)
        Dim Adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.Refresh()
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        FilterData(txtID.Text)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        FilterData(txtID.Text)
    End Sub
End Class