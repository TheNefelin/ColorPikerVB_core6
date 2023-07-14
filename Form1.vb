Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), New Drawing.Point(0, 0), BMP.Size)
        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)
        pnlColor.BackColor = Pixel
        txtlRojo.Text = Pixel.R
        txtAzul.Text = Pixel.B
        txtVerde.Text = Pixel.G
    End Sub

End Class
