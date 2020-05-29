Imports System.Data.SqlClient
Public Class STUDENTRESULTS
Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())
            Dim da = New DataTable()
            If (TextBox1.Text.Length > 0) Then

                Dim sda = New SqlDataAdapter("Select  Mathematics.StudentID,Mathematics.Subject,Mathematics.Grade, Integrated_Science.Subject ,Integrated_Science.GRADE,English_Language.Subject,English_Language.Grade,Biology.Subject,Biology.Grade, History.Subject,History.Grade,Chemistry.Subject,Chemistry.Grade,Social_Studies.Subject,Social_Studies.Grade from Mathematics LEFT OUTER  JOIN Integrated_Science on Mathematics.StudentID =  Integrated_Science.Integid LEFT OUTER  JOIN English_Language on Mathematics.StudentID=English_Language.eid LEFT OUTER  JOIN Biology on Mathematics.StudentID=Biology.BioID LEFT OUTER  JOIN History on Mathematics.StudentID=History.HisroyID LEFT OUTER  JOIN Chemistry on Mathematics.StudentID=Chemistry.ChemicID LEFT OUTER  JOIN Social_Studies on Mathematics.StudentID=Social_Studies.socid where Mathematics.StudentID like '" + TextBox1.Text + "%' ", con)
                'Dim sda = New SqlDataAdapter("Select Mathematics.StudentID, Mathematics.Subject,Mathematics.Grade from Mathematics  INNER JOIN Integrated_Science.Integid where Mathematics.StudentID like '" + TextBox1.Text + "%' ", con)
                sda.Fill(da)
                DataGridView1.DataSource = da
            Else
                MessageBox.Show("Records not  found")

                '        SELECT 
                'users.email, users.password, data.data_1, data.data_2
                'FROM 
                'users
                'INNER JOIN 
                'data 
                ' ON
                'users.user_id=data.user_id
                'WHERE 
                'users.email='$user_email'                              

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub STUDENTRESULTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PRINTRESULT.Show()

    End Sub
End Class