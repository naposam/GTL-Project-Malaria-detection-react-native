Public Class SecondSplash


    Private Sub SecondSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen (*.png)|*.png |ALL Files|*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()

            Me.Hide()

            LOGIN_FORM.Show()
        End If
    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class