Imports System.Data.SqlClient
Public Class StudentLogIn
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub StudentLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Left = Me.Width

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTimer.Text = TimeOfDay()

        If Label1.Left = 0 - Label1.Width Then
            Label1.Left = Me.Width
            Label1.Left = Label1.Left - 2
        Else
            Label1.Left = Label1.Left - 2
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim peaceOut As String
        peaceOut = MsgBox("Do you want exit Login?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "")
        If peaceOut = vbYes Then
            Me.Hide()
        ElseIf peaceOut = vbNo Then
            MsgBox("All System Standby for the next Instruction", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString)

        cmd = New SqlCommand(" select * from Student Where StudentID=@u and StudentID=@P ", con)
        con.Open()
        cmd.Parameters.Add("@u", SqlDbType.NChar).Value = TextBox1.Text
        cmd.Parameters.AddWithValue("@p", SqlDbType.NChar).Value = TextBox2.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Please use your ID As password and username")
            cmd.Parameters.Clear()
        Else
            Me.Hide()
            STUDENTRESULTS.Show()


        End If
    End Sub
End Class