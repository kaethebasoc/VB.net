Imports System.IO

Public Class RRGameOver

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        RussianRoulette.Show()
        RRGame.Close()
        Me.Close()
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        RRHighScore.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub RRGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayerName.Text = RussianRoulette.UserName
        lblPlayerScore.Text = RRGame.Points

        Dim Path As String
        Path = "S:\Software\Kaethe Basoc\Russian Roulette\HighScore.txt"

        Try
            Dim FileWrite As StreamWriter

            FileWrite = File.AppendText(Path)
            FileWrite.WriteLine(RussianRoulette.UserName & "," & lblPlayerScore.Text)

            FileWrite.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class