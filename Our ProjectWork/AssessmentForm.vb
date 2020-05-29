
Imports System.Data.SqlClient
Public Class AssessmentForm

    Dim con As SqlConnection
    Dim cmd As SqlCommand
  
    Private Sub TextBox18_Enter(sender As Object, e As EventArgs) Handles TextBox18.Enter
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        If Val(TextBox18.Text) > Val(TextBox27.Text) Or Val(TextBox27.Text) < Val(TextBox18.Text) Then
            MessageBox.Show("Marks Obtain by Student cannot be greater than the Total Score")

            TextBox18.Clear()

        Else
            txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        txtRawScore.Text = (Val(TextBox18.Text) + Val(TextBox17.Text) + Val(TextBox16.Text) + Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox12.Text) + Val(TextBox11.Text) + Val(TextBox10.Text))
    End Sub

    Private Sub TextBox27_Enter(sender As Object, e As EventArgs) Handles TextBox27.Enter
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        txtOverRawMark.Text = Val(TextBox26.Text) + (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        txtOverRawMark.Text = (Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text))
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub txtRawExams_TextChanged(sender As Object, e As EventArgs) Handles txtRawExams.TextChanged
        Try


            If (txtRawExams.Text > 100) Then
                MessageBox.Show("Examination Score Must not exceed 100%")
                txtRawExams.Clear()
            Else
                txtConExams.Text = (Val(txtRawExams.Text) / 100) * 70
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCGrade_Click(sender As Object, e As EventArgs) Handles btnCGrade.Click
        txtExamsTotal.Text = Val(txtConExams.Text)
        txtTotalCa.Text = Format((Val(txtRawScore.Text) / Val(txtOverRawMark.Text)) * 30, "#0.00")
        txtTotalScore.Text = Format(Val(txtTotalCa.Text) + Val(txtExamsTotal.Text), "#0.00")
        '' Format(T1a, "#0.00")
        If Val(txtTotalScore.Text) >= 80 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "A"
        ElseIf Val(txtTotalScore.Text) >= 75 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "B+"

        ElseIf Val(txtTotalScore.Text) >= 70 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "B"
        ElseIf Val(txtTotalScore.Text) >= 65 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "C+"
        ElseIf Val(txtTotalScore.Text) >= 60 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "C"
        ElseIf Val(txtTotalScore.Text) >= 55 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "D+"
        ElseIf Val(txtTotalScore.Text) >= 50 Then
            txtGrade.Text.ToString()
            txtGrade.Text = "D"
        Else

            txtGrade.Text.ToString()
            txtGrade.Text = "E"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'TextBox10.Clear()
        'TextBox11.Clear()
        'TextBox12.Clear()
        'TextBox13.Clear()
        'TextBox14.Clear()
        'TextBox15.Clear()
        'TextBox17.Clear()
        'TextBox16.Clear()
        'TextBox18.Clear()
        ComboBox1.SelectedIndex = -1
        For Each ctr As Control In GroupBox1.Controls

            If TypeOf ctr Is TextBox Then
                CType(ctr, TextBox).Text = Nothing

            End If
        Next
        For Each ctr As Control In GroupBox2.Controls

            If TypeOf ctr Is TextBox Then
                CType(ctr, TextBox).Text = Nothing

            End If
        Next
        For Each ctr As Control In GroupBox3.Controls

            If TypeOf ctr Is TextBox Then
                CType(ctr, TextBox).Text = Nothing

            End If
        Next
        For Each ctr As Control In GroupBox4.Controls

            If TypeOf ctr Is TextBox Then
                CType(ctr, TextBox).Text = Nothing

            End If
        Next
        For Each ctr As Control In GroupBox5.Controls

            If TypeOf ctr Is TextBox Then
                CType(ctr, TextBox).Text = Nothing

            End If
        Next

    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub txtConExams_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConExams.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox23.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox22.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True



        End If
    End Sub

    Private Sub txtRawExams_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRawExams.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
          Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Only Numbers Are Allowed")
            e.Handled = True


        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Try


                con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
                Dim dr As SqlDataReader

            If txtStudentID.Text = Nothing Then
                MsgBox("Please Enter Student Index Number")
                txtStudentID.Focus()
                txtStudentID.Text = ""
            ElseIf ComboBox1.SelectedItem = Nothing Then
                MsgBox("Please select a subject")
            ElseIf txtTotalScore.Text = Nothing Then
                MsgBox("Please Enter student marks")
           
            ElseIf txtExamsTotal.Text = Nothing Then
                MsgBox("Please Enter student Exams Score")
            ElseIf txtTotalCa.Text = Nothing Then
                MsgBox("Please Click the Calulate grade button before Saving")
            Else
                'If ((txtStudentID.Text = "") And (txtExamsTotal.Text = "") And (txtRawExams.Text = "") And
                '      (ComboBox1.SelectedItem = Nothing) And (txtTotalCa.Text = "") And (txtTotalScore.Text = "") And (txtOverRawMark.Text = "") And (txtRawScore.Text)) Then
                '    MessageBox.Show("One or more fields are empty or You need to Calculate Grade......!!")
                'End If

                con.Open()
                If ComboBox1.SelectedItem = "Mathematics" Then
                    cmd = New SqlCommand("Select * from History where HisroyID like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into Mathematics (StudentID,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If
                    End If

                ElseIf ComboBox1.SelectedItem = "English Language" Then
                    cmd = New SqlCommand("Select * from English_Language   where eid like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)

                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into English_Language (eid,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                ElseIf ComboBox1.SelectedItem = "Integrated Science" Then
                    cmd = New SqlCommand("Select * from Integrated_Science   where Integid like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                        con.Close()

                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into Integrated_Science (Integid,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                ElseIf ComboBox1.SelectedItem = "Social Studies" Then
                    cmd = New SqlCommand("Select * from Social_Studies   where socid like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)

                    Else
                        con.Close()
                        con.Open()

                        cmd = New SqlCommand("insert into Social_Studies (socid,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                ElseIf ComboBox1.SelectedItem = "Biology" Then
                    cmd = New SqlCommand("Select * from Biology where BioID like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                        con.Close()
                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into Biology (BioID,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                ElseIf ComboBox1.SelectedItem = "Chemistry" Then
                    cmd = New SqlCommand("Select * from Chemistry where chemicID like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)
                        con.Close()
                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into Chemistry (chemicID,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                ElseIf ComboBox1.SelectedItem = "History" Then
                    cmd = New SqlCommand("Select * from History where HisroyID like '" + txtStudentID.Text + "%' ", con)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        MsgBox("Duplicate Entry found", MsgBoxStyle.Critical)

                    Else
                        con.Close()
                        con.Open()
                        cmd = New SqlCommand("insert into History (HisroyID,RawAssessmentScore,TotalRawAssessment,TotalAssessmentScore,ExamsScore,Total_Exams_Score,Total_Score,Grade,Subject)values(@id,@ra,@tr,@ta,@es,@te,@tScore,@gra,@Sub)", con)
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                        cmd.Parameters.AddWithValue("@ra", txtRawScore.Text)
                        cmd.Parameters.AddWithValue("@tr", txtOverRawMark.Text)
                        cmd.Parameters.AddWithValue("@ta", txtTotalCa.Text)
                        cmd.Parameters.AddWithValue("@es", txtRawExams.Text)
                        cmd.Parameters.AddWithValue("@te", txtExamsTotal.Text)
                        cmd.Parameters.AddWithValue("@tScore", txtTotalScore.Text)
                        cmd.Parameters.AddWithValue("@gra", txtGrade.Text)
                        cmd.Parameters.AddWithValue("@Sub", ComboBox1.SelectedItem)
                        If cmd.ExecuteNonQuery > 0 Then
                            MessageBox.Show("Data Saved Successfully")
                        End If

                    End If

                End If
                End If
        Catch ex As Exception
            MessageBox.Show("Duplicate Entry found....", "Multiple Records Entery")
            con.Close()

        End Try

    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        DashBoard.Show()

    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso
         Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Valid Student ID")
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub AssessmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class