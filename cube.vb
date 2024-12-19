Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Start()
        Timer1.Stop()
        Timer3.Stop()
        Timer4.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer3.Start()
        Timer2.Stop()
        Timer1.Stop()
        Timer4.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer4.Start()
        Timer2.Stop()
        Timer3.Stop()
        Timer1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button5.Location = New Point(Button5.Location.X, Button5.Location.Y - 5)
        Button6.Text = "Position X: " & Button5.Location.X & ", Y:" & Button5.Location.Y & vbCrLf & "Breite: " & Button5.Size.Width & ", Höhe: " & Button5.Size.Height
        If Button5.Location.Y <= 20 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button5.Location = New Point(Button5.Location.X, Button5.Location.Y + 5)
        Button6.Text = "Position X: " & Button5.Location.X & ", Y:" & Button5.Location.Y & vbCrLf & "Breite: " & Button5.Size.Width & ", Höhe: " & Button5.Size.Height
        If Button5.Location.Y >= 550 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Button5.Location = New Point(Button5.Location.X - 5, Button5.Location.Y)
        Button6.Text = "Position X: " & Button5.Location.X & ", Y:" & Button5.Location.Y & vbCrLf & "Breite: " & Button5.Size.Width & ", Höhe: " & Button5.Size.Height
        If Button5.Location.X <= 50 Then
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Button5.Location = New Point(Button5.Location.X + 5, Button5.Location.Y)
        Button6.Text = "Position X: " & Button5.Location.X & ", Y:" & Button5.Location.Y & vbCrLf & "Breite: " & Button5.Size.Width & ", Höhe: " & Button5.Size.Height
        If Button5.Location.X >= 1200 Then
            Timer4.Stop()
        End If
    End Sub
End Class
