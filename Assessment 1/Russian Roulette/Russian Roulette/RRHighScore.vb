Imports System.IO

Public Class RRHighScore

    Private Sub RRHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Path As String
        Path = "S:\Software\Kaethe Basoc\Russian Roulette\HighScore.txt"

        Dim Line As String
        Dim HighScore() As String
        Dim RowCount As Integer

        Try
            Dim FileRead As StreamReader
            FileRead = New StreamReader(Path)
            Do Until FileRead.EndOfStream
                Line = FileRead.ReadLine
                HighScore = Line.Split(",")

                DGVHighScore.Rows.Add()
                DGVHighScore.Rows(RowCount).Cells(0).Value = HighScore(0)
                DGVHighScore.Rows(RowCount).Cells(1).Value = HighScore(1)

                RowCount = RowCount + 1
            Loop
            FileRead.Close()
                Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class