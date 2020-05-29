Imports System.Data.SqlClient
Imports System.IO
Public Class UpdateStudentRecords
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If



            cmd = New SqlCommand("update  Student set FirstName='" & txtFirstName.Text & "',MiddleName='" & txtMiddleName.Text & "',LastName='" & txtLastName.Text & "',DOB='" & dtpDOB.Value & "',Address='" & txtAddress.Text & "',Picture=@pic  where StudentID= '" & txtStudentID.Text & "' ", con)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()
            cmd.ExecuteNonQuery()
            MsgBox("Updated successfully")

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()

        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        txtLastName.Clear()
        PictureBox1.Image = Nothing
     

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim peaceOut As String
        peaceOut = MsgBox("please confirm cancelling the Registration", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "All System Out")
        If peaceOut = vbYes Then
            MsgBox("All System Out", MsgBoxStyle.Information)
            Me.Hide()

        ElseIf peaceOut = vbNo Then
            MsgBox("All System Standby for the next Instruction", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
         Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Valid Student ID")
            e.Handled = True
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                MsgBox("Please enter a valid name")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                MsgBox("Please enter a valid name")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                MsgBox("Please enter a valid name")
                e.Handled = True
            End If
        End If
    End Sub
End Class