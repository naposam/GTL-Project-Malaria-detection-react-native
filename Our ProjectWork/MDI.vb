Public Class MDI

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub STAFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STAFFToolStripMenuItem.Click

        Register.MdiParent = Me
        Register.WindowState = FormWindowState.Normal

        Register.Show()
    End Sub

    Private Sub STUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTToolStripMenuItem.Click
        STUDENTREG.MdiParent = Me

        STUDENTREG.WindowState = FormWindowState.Normal

        STUDENTREG.Show()
    End Sub

    Private Sub AsStudentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        StudentLogIn.MdiParent = Me
        StudentLogIn.WindowState = FormWindowState.Normal

        StudentLogIn.Show()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        LogIN.MdiParent = Me
        LogIN.WindowState = FormWindowState.Normal

        LogIN.Show()

    End Sub

    Private Sub VIEWRECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWRECORDSToolStripMenuItem.Click
        AssessmentForm.MdiParent = Me
        AssessmentForm.WindowState = FormWindowState.Normal

        AssessmentForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UPDATERECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATERECORDSToolStripMenuItem.Click
       
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub StaffRecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffRecordsToolStripMenuItem1.Click
        UPDATERECORDS.MdiParent = Me
        UPDATERECORDS.WindowState = FormWindowState.Normal

        UPDATERECORDS.Show()

    End Sub

    Private Sub RESULTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESULTSToolStripMenuItem.Click
        STUDENTRESULTS.MdiParent = Me
        STUDENTRESULTS.WindowState = FormWindowState.Normal

        STUDENTRESULTS.Show()
    End Sub

    Private Sub StaffRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffRecordsToolStripMenuItem.Click
        StaffRecords.MdiParent = Me
        StaffRecords.WindowState = FormWindowState.Normal

        StaffRecords.Show()
    End Sub

    Private Sub StudentRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRecordsToolStripMenuItem.Click
        STUDENTREGVIEWER.MdiParent = Me
        STUDENTREGVIEWER.WindowState = FormWindowState.Normal
        STUDENTREGVIEWER.Show()
    End Sub

    Private Sub StudentRecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentRecordsToolStripMenuItem1.Click
        UpdateStudentRecords.MdiParent = Me
        UpdateStudentRecords.WindowState = FormWindowState.Normal
        UpdateStudentRecords.Show()
    End Sub

    Private Sub PRINTRESULTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTRESULTSToolStripMenuItem.Click
        PRINTRESULT.MdiParent = Me
        PRINTRESULT.WindowState = FormWindowState.Normal
        PRINTRESULT.Show()
    End Sub

    Private Sub REGISTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTERToolStripMenuItem.Click

    End Sub

    Private Sub GENERALRESULTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERALRESULTToolStripMenuItem.Click
        GENERALRESULTS.MdiParent = Me
        GENERALRESULTS.WindowState = FormWindowState.Normal
        GENERALRESULTS.Show()
    End Sub

    Private Sub SUBJECTRESULTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBJECTRESULTToolStripMenuItem.Click
        DashBoard.MdiParent = Me
        DashBoard.WindowState = FormWindowState.Normal
        DashBoard.Show()
    End Sub
End Class