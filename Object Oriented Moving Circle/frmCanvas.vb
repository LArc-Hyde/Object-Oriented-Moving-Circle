Public Class frmCanvas

    Dim WithEvents round As New Circle()

    Sub round_PositionChanged(x As Integer, y As Integer, d As Integer) Handles round.PositionChanged

        txtCaution.Text = x.ToString + "," + y.ToString
        If (x + d > picCircle.Width) Or (y + d > picCircle.Height) Then
            txtCaution.Text = "Circle Off Screen"
        End If
    End Sub


    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        round.Move(20)
        round.Show(picCircle.CreateGraphics)

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
