Imports System.Data.SqlClient
Public Class AdminLog
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString)

        cmd = New SqlCommand(" select * from Admin2 Where Username=@u and Password=@P ", con)
        con.Open()
        cmd.Parameters.Add("@u", SqlDbType.NChar).Value = txtUser.Text
        cmd.Parameters.AddWithValue("@p", SqlDbType.NChar).Value = txtPass.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Username or password is Invalid")
            cmd.Parameters.Clear()
        Else
            Me.Hide()
            ADMINVIEWRECORDS.ShowDialog()
        End If

        '' If con.State = ConnectionState.Closed Then
        'con.Open()
        'End If
        'If cmd.ExecuteNonQuery() = 1 Then
        '    Me.Hide()
        '    ADMINVIEWRECORDS.ShowDialog()
        'Else
        '    MessageBox.Show("invalid username or Password")
        'End If
        'cmd.Parameters.Clear()
        'con.Close()

    End Sub

    Private Sub AdminLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LblWel.Left = Me.Width
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If LblWel.Left = 0 - LblWel.Width Then
            LblWel.Left = Me.Width
            LblWel.Left = LblWel.Left - 2
        Else
            LblWel.Left = LblWel.Left - 2


        End If
        LbTim.Text = TimeOfDay

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
End Class