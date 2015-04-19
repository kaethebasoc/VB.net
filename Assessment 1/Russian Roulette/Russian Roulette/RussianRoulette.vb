Public Class RussianRoulette

    Public UserName As String

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        UserName = txtName.Text
        If UserName = "" Then
            MsgBox("Please enter your name.")
        Else
            RRGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        RRHighScore.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar)
    End Sub

    Private Sub RussianRoulette_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
