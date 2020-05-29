Public Class ADMINVIEWRECORDS

    Private Sub btnVStaff_Click(sender As Object, e As EventArgs) Handles btnVStaff.Click
        Me.Hide()
        StaffRecords.ShowDialog()

    End Sub

    Private Sub btnVStudent_Click(sender As Object, e As EventArgs) Handles btnVStudent.Click
        Me.Hide()
        StudentRecords.ShowDialog()
    End Sub
End Class