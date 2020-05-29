Imports System.Data.SqlClient
Public Class DashBoard
    Dim con As SqlConnection
    Dim cdm As SqlCommand
    Public Sub FilterData(valueToSearch As String)
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Dim SearchQuary As String = "SELECT * From Mathematics,English_Language,Integrated_Science, Social_Studies, Biology,Chemistry,History WHERE CONCAT(Mathematics.StudentID,English_Language.eid,Integrated_Science.Integid,Biology.BioID,Chemistry.chemicID,History.HisroyID) like '%" & valueToSearch & "%'"


        Dim cmd As New SqlCommand(SearchQuary, con)
        Dim Adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
        End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If ComboBox1.SelectedItem = "Mathematics" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  Mathematics"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "English Language" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  English_Language"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "Integrated Science" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  Integrated_Science"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "Social Studies" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  Social_Studies"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "Biology" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  Biology"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "Chemistry" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  Chemistry"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        ElseIf ComboBox1.SelectedItem = "History" Then
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


            Dim SearchQuary As String = "SELECT * FROM  History"


            Dim cmd As New SqlCommand(SearchQuary, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            Adapter.Fill(table)
            DataGridView1.DataSource = table
        Else
            MessageBox.Show("No Subject Selected")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FilterData(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peaceOut As String
        peaceOut = MsgBox("Do you want exit the Dashboard?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "")
        If peaceOut = vbYes Then
            Me.Hide()
        ElseIf peaceOut = vbNo Then
            MsgBox("All System Standby for the next Instruction", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class