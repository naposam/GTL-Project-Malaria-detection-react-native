Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen (*.png)|*.png |ALL Files|*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()



        End If
    End Sub
End Class
