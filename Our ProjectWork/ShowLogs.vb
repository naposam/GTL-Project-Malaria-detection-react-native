Imports System.Data.SqlClient
Imports System.IO
Public Class ShowLogs

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString)

        cmd = New SqlCommand(" select * from Staff Where StuffID=@u and Password=@P ", con)
        con.Open()
        cmd.Parameters.Add("@u", SqlDbType.NChar).Value = TextBox1.Text
        cmd.Parameters.AddWithValue("@p", SqlDbType.NChar).Value = TextBox2.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Username or password is Invalid")
            cmd.Parameters.Clear()
        Else

            UPDATERECORDS.ShowDialog()
            Me.Hide()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim peaceOut As String
        peaceOut = MsgBox("Do you want exit Login?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "")
        If peaceOut = vbYes Then
            Me.Hide()
        ElseIf peaceOut = vbNo Then
            MsgBox("All System Standby for the next Instruction", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ShowLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labbtim.Text = TimeOfDay
    End Sub

    Private Sub labbtim_Click(sender As Object, e As EventArgs) Handles labbtim.Click

    End Sub
End Class