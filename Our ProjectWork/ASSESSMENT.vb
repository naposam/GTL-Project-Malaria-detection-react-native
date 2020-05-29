Imports System.Data.SqlClient
Public Class ASSESSMENT
    Dim con As sqlconnection
    Dim cmd As sqlcommand


    Private Sub btnAddCA_Click(sender As Object, e As EventArgs) Handles btnAddCA.Click
        'txtTotalCA.Text = Val(txtCA1.Text) + Val(txtCA2.Text)
        'If Val(txtCA1.Text) + Val(txtCA2.Text) > 40 Then
        '    MsgBox("Assessment should not exceed 40")
        '    txtTotalCA.Clear()

        'End If
        'If Val(txtCA1.Text) / 100 * 40 > 40 Then
        '    MsgBox("should not exceed 40")

        'Else

        txtTotalCA.Text = (Val(txtCA1.Text) / 100) * 40
        'End If

    End Sub

    Private Sub btnCaculate_Click(sender As Object, e As EventArgs) Handles btnCaculate.Click


        'txtTotalScore.Text = Val(txtExams.Text) / 100 * 60
        'If Val(txtTotalScore.Text) + Val(txtTotalCA) >= 80 Then
        '    lblGrade.Text.ToString()
        '    lblGrade.Text = "A"
        'End If

        txtTotalScore.Text = Val(txtTotalCA.Text) + Val(txtExams.Text)
        If Val(txtTotalCA.Text) + Val(txtExams.Text) >= 80 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "A"
        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 75 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "B+"

        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 70 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "B"
        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 65 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "C+"
        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 60 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "C"
        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 55 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "D+"
        ElseIf Val(txtTotalCA.Text) + Val(txtExams.Text) >= 50 Then
            lblGrade.Text.ToString()
            lblGrade.Text = "D"
        Else
            lblGrade.Text.ToString()
            lblGrade.Text = "E"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
        cmd = New SqlCommand("insert into Scoretable(STID,ASSESSMENT_ONE,ASSESSMENT_TWO,TOTAL_ASSESSMENT,EXAMS_SCORE,TOTAL_SCORE,GRADE,SUBJECT)VALUES(@st,@A,@as,@tos,@exm,@ts,@grde,@sub)", con)
        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        cmd.Parameters.Add("@st", SqlDbType.Int).Value = txtID.Text
        cmd.Parameters.Add("@A", SqlDbType.NVarChar).Value = txtCA1.Text
        cmd.Parameters.Add("@as", SqlDbType.NVarChar).Value = txtCA2.Text
        cmd.Parameters.Add("@tos", SqlDbType.NVarChar).Value = txtTotalCA.Text
        cmd.Parameters.Add("@exm", SqlDbType.NVarChar).Value = txtExams.Text
        cmd.Parameters.Add("@ts ", SqlDbType.NVarChar).Value = txtTotalScore.Text
        cmd.Parameters.Add("@grde", SqlDbType.NVarChar).Value = lblGrade.Text
        cmd.Parameters.Add("@sub", SqlDbType.NVarChar).Value = cboSelectSUB.SelectedItem
        If cboSelectSUB.SelectedItem IsNot cboSub2.SelectedItem Then
            MsgBox("Subject does not match")
        Else

            Try
                cmd.ExecuteNonQuery()
            Catch Ex As Exception
                MsgBox(Ex.Message)
            End Try

            con.Close()
            MsgBox("Data Save", MsgBoxStyle.OkOnly, "save details")
        End If
        cmd.Parameters.Clear()
        con.Close()

    End Sub

    Private Sub btnViewrecord_Click(sender As Object, e As EventArgs) Handles btnViewrecord.Click
        ResultView.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()

    End Sub

    Private Sub cboSub2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSub2.SelectedIndexChanged

    End Sub
End Class