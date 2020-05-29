Imports System.Data.SqlClient
Public Class LOGIN_FORM

    Dim con As SqlConnection
    Dim cmd As SqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ((TextBox1.Text = " ") Or (TextBox2.Text = " ") Or (ComboBox1.SelectedItem = Nothing)) Then
                MessageBox.Show("Select Role to Continue")
            End If

            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString)
            If ComboBox1.SelectedItem = "Admin" Then
                cmd = New SqlCommand(" select * from Admin2 Where Username=@u and Password=@P ", con)
                con.Open()
                cmd.Parameters.Add("@u", SqlDbType.NChar).Value = TextBox1.Text
                cmd.Parameters.AddWithValue("@p", SqlDbType.NChar).Value = TextBox2.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count <= 0 Then
                    MessageBox.Show("Username or password is Invalid")
                    cmd.Parameters.Clear()
                    TextBox1.Clear()
                    TextBox2.Clear()
                Else
                    Me.Hide()
                    Me.Close()

                    MDI.ShowDialog()
                    TextBox1.Clear()
                    TextBox2.Clear()
                End If
            ElseIf ComboBox1.SelectedItem = "Student" Then

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
                    TextBox1.Clear()
                    TextBox2.Clear()
                Else
                    Me.Hide()


                    STUDENTRESULTS.Show()
                    TextBox1.Clear()
                    TextBox2.Clear()

                End If
            ElseIf ComboBox1.SelectedItem = "Staff" Then

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
                    TextBox1.Clear()
                    TextBox2.Clear()

                Else
                    Me.Hide()

                    MDI.ShowDialog()

                    TextBox1.Clear()
                    TextBox2.Clear()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'If ComboBox1.SelectedItem = "Student" And TextBox1.Text = "student" And TextBox2.Text = "student" Then
        '    Me.Hide()
        '    MsgBox("Login Successfull")
        '    STUDENTRESULTS.ShowDialog()
        'ElseIf ComboBox1.SelectedItem = "Staff" And TextBox1.Text = "Sam" And TextBox2.Text = "sam" Then
        '    Me.Hide()
        '    MsgBox("Login Successfull")
        '    AssessmentForm.ShowDialog()
        'ElseIf ComboBox1.SelectedItem = "Admin" And TextBox1.Text = "Admin" And TextBox2.Text = "admin123" Then

        '    Me.Hide()

        '    MsgBox("Login Successfull")
        '    AssessmentForm.ShowDialog()
        'Else
        '    MsgBox("Invalid password")
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try

       

            MDI.Show()


        Catch ex As Exception

        End Try


    End Sub

   
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim peaceOut As String
        peaceOut = MsgBox("please confirm Exiting the LogIn", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "All System Out")
        If peaceOut = vbYes Then
            MsgBox("All System Out", MsgBoxStyle.Information)
            Me.Close()
        ElseIf peaceOut = vbNo Then
            MsgBox("All System Standby for the next Instruction", MsgBoxStyle.Information)
        End If
    End Sub
End Class