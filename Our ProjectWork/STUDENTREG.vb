
Imports System.Data.SqlClient
Imports System.IO
Public Class STUDENTREG

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()
        Try
            con.Open()
            cmd = New SqlCommand("Select * from Student where StudentID='" & txtStudentID.Text & "' ", con)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()

                '" & txtUserID.Text & "','" & txtUserName.Text & "','" & gender & "','" & dtpDOB.Value & "','" & cboStatus.SelectedItem & "','" & txtEmail.Text & "','" & txtContact.Text & "','" & txtSalary.Text & "'
                cmd = New SqlCommand("Insert into Student (StudentID,FirstName,MiddleName,LastName,Address,DOB,Gender,Year,Picture)values(@id,@fn,@mn,@las,@add,@dob,@gender,@yaer,@Picture)", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtStudentID.Text
                cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = txtFirstName.Text
                cmd.Parameters.Add("@mn", SqlDbType.NVarChar).Value = txtMiddleName.Text
                cmd.Parameters.Add("@las", SqlDbType.NVarChar).Value = txtLastName.Text
                cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = txtAddress.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dtpDOB.Value
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = cboGender.SelectedItem
                cmd.Parameters.Add("@yaer", SqlDbType.NVarChar).Value = txtYear.SelectedItem
                cmd.Parameters.Add("@Picture", SqlDbType.Image).Value = mstream.ToArray

                cmd.ExecuteNonQuery()
                MsgBox("Data Saved Successfully")
                STUDENTREGVIEWER.StudentDataGridView.Refresh()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If  
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtStudentID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        txtLastName.Clear()

        PictureBox1.Image = Nothing
        txtYear.SelectedIndex = -1

        cboGender.SelectedIndex = -1



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
            MsgBox("Enter Numbers")
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