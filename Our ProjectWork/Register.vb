Imports System.Data.SqlClient
Imports System.IO
Public Class Register
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim gender As String
    Dim dr As SqlDataReader
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If ((txtUserID.Text = "") Or (txtFname.Text = "") Or (txtLastName.Text = "") Or (txtTelNumber.Text = "") Or
                    (cboStatus.Text = "") Or (txtPass.Text = "") Or (txtConPass.Text = "")) Then


                MessageBox.Show("One or more fields are empty......!!")
            ElseIf txtPass.Text.CompareTo(txtConPass.Text) Then
                MessageBox.Show("OOPS!!! Your password do not much")
            Else


                con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
                con.Open()
                cmd = New SqlCommand("Select * from Staff where StuffID='" & txtUserID.Text & "' ", con)
                dr = cmd.ExecuteReader()

                If dr.HasRows Then
                    MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                    con.Close()
                Else
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("INSERT INTO Staff values(@id,@fn,@mn,@ln,@dob,@gen,@em,@Rol,@p,@cp,@pic)", con)
                    Dim ms As New MemoryStream
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    cmd.Parameters.AddWithValue("@id", txtUserID.Text)
                    cmd.Parameters.AddWithValue("@fn", txtFname.Text)
                    cmd.Parameters.AddWithValue("@mn", txtMName.Text)
                    cmd.Parameters.AddWithValue("@ln", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@dob", dtpDOB.Value)
                    cmd.Parameters.AddWithValue("@gen", gender)
                    cmd.Parameters.AddWithValue("@em", txtTelNumber.Text)
                    cmd.Parameters.AddWithValue("@Rol", cboStatus.SelectedItem)
                    cmd.Parameters.AddWithValue("@p", txtPass.Text)
                    cmd.Parameters.AddWithValue("@cp", txtConPass.Text)
                    cmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()

                    cmd.ExecuteNonQuery()

                    MsgBox("Data Save", MsgBoxStyle.OkOnly, "save details")

                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
            con.Close()
            cmd.Parameters.Clear()

        End Try







    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub lnkUpload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUpload.LinkClicked
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserID.Clear()
        cboStatus.SelectedIndex = -1
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtTelNumber.Clear()
        txtPass.Clear()
        txtConPass.Clear()
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
    Private Sub txtUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserID.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
           Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers")
            e.Handled = True
        End If
    End Sub
    Private Sub txtTelNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelNumber.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
            Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please Enter Telephone Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub txtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFname.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                MsgBox("Please enter a valid name")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMName.KeyPress
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

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class