Public Class PRINTRESULT

    Private Sub PRINTRESULT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'PRINTDataSet1.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.PRINTDataSet1.DataTable1)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

        
        Me.DataTable1TableAdapter.FillBy(Me.PRINTDataSet1.DataTable1, TextBox1.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class