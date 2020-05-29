Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            LOGIN_FORM.Show()


        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen (*.png)|*.png |ALL Files|*.*"
    End Sub

   
End Class