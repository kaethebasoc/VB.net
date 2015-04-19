
Public Class RRGame

    Dim LoadBullet As Integer
    Dim RandomBullet As New Random
    Dim FireChances As Integer = 1
    Dim ShotAwayChances As Integer = 1
    Dim ChamberIMG As Integer
    Public Points As Double

    Private Sub btnLoadBullet_Click(sender As Object, e As EventArgs) Handles btnLoadBullet.Click
        If My.Resources.LoadBullet.CanRead Then
            Dim bStr(My.Resources.LoadBullet.Length) As Byte
            My.Resources.LoadBullet.Read(bStr, 0, My.Resources.LoadBullet.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If

        Button()
    End Sub

    Private Sub btnSpinChambers_Click(sender As Object, e As EventArgs) Handles btnSpinChamber.Click
        If My.Resources.SpinChamber.CanRead Then
            Dim bStr(My.Resources.SpinChamber.Length) As Byte
            My.Resources.SpinChamber.Read(bStr, 0, My.Resources.SpinChamber.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If

        LoadBullet = RandomBullet.Next(1, 6)

        Button()

        Timer1.Start()
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        If My.Resources.GunShot.CanRead Then
            Dim bStr(My.Resources.GunShot.Length) As Byte
            My.Resources.GunShot.Read(bStr, 0, My.Resources.GunShot.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If

        Button()
        FireCondition()

        Timer1.Stop()
        pbChamber.Image = My.Resources.Chamber_1
    End Sub

    Private Sub btnShotAway_Click(sender As Object, e As EventArgs) Handles btnShotAway.Click
        If My.Resources.GunShot.CanRead Then
            Dim bStr(My.Resources.GunShot.Length) As Byte
            My.Resources.GunShot.Read(bStr, 0, My.Resources.GunShot.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If

        If LoadBullet = FireChances Then
            MsgBox("You win!")
            Points = Points + 10000
            RRGameOver.Show()
            Me.Close()
        ElseIf ShotAwayChances = 1 And LoadBullet <> FireChances Then
            MsgBox("You only have one chance left.")
        ElseIf ShotAwayChances = 2 And LoadBullet <> FireChances Then
            btnShotAway.Enabled = False
        End If

        FireChances = FireChances + 1
        ShotAwayChances = ShotAwayChances + 1

        Button()
        BulletHide()

        Timer1.Stop()
        pbChamber.Image = My.Resources.Chamber_1
    End Sub

    Private Sub RRGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = "Hi " & RussianRoulette.UserName & "!"
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        RussianRoulette.Show()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        RRGameOver.Show()
        Me.Close()
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        RRHighScore.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Max As Integer = 10
        Dim Random As New Random
        Dim Random2 As Integer = Random.Next(10, Max + 1)
        Dim Index As Integer = 1
        Dim Number(Max - 1) As Integer

        For Index = 0 To Max - 1
            If Number(Index) = Random2 Then
                Random2 = Random.Next(1, Max + 1)
                Index = -1
            ElseIf Number(Index) = 0 Then
                Number(Index) = Random2
                Random2 = Random.Next(1, Max + 1)
                If Index = Max - 1 Then
                    Exit For
                End If
                Index = -1
            End If
        Next

        Timer1.Interval = Number(Index)
        Index += 1

        ImageRotation()
    End Sub

    Private Sub ImageRotation()
        Select Case ChamberIMG
            Case 0
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_1
                ChamberIMG += 1
            Case 1
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_2
                ChamberIMG += 1
            Case 2
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_3
                ChamberIMG += 1
            Case 3
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_4
                ChamberIMG += 1
            Case 4
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_5
                ChamberIMG += 1
            Case 5
                pbChamber.Visible = True
                pbChamber.Image = My.Resources.Chamber_6
                ChamberIMG = 0
        End Select
    End Sub

    Public Sub FireCondition()
        If LoadBullet = FireChances Then
            pbChamber.Image = My.Resources.Chamber
            PBBullet1.Visible = False
            PBBullet2.Visible = False
            PBBullet3.Visible = False
            PBBullet4.Visible = False
            PBBullet5.Visible = False
            PBBullet6.Visible = False
            MsgBox("You shot yourself!" & vbCrLf & "Hint: You have 2 chances to shoot away.")
            Points = 0
            RRGameOver.Show()
            Me.Hide()
        ElseIf FireChances = 5 And LoadBullet <> FireChances Then
            PBBullet1.Visible = True
            PBBullet2.Visible = False
            PBBullet3.Visible = False
            PBBullet4.Visible = False
            PBBullet5.Visible = False
            PBBullet6.Visible = False
            Points = Points + 2000
        ElseIf FireChances = 4 And LoadBullet <> FireChances Then
            PBBullet1.Visible = True
            PBBullet2.Visible = True
            PBBullet3.Visible = False
            PBBullet4.Visible = False
            PBBullet5.Visible = False
            PBBullet6.Visible = False
            Points = Points + 1000
        ElseIf FireChances = 3 And LoadBullet <> FireChances Then
            PBBullet1.Visible = True
            PBBullet2.Visible = True
            PBBullet3.Visible = True
            PBBullet4.Visible = False
            PBBullet5.Visible = False
            PBBullet6.Visible = False
            Points = Points + 500
        ElseIf FireChances = 2 And LoadBullet <> FireChances Then
            PBBullet1.Visible = True
            PBBullet2.Visible = True
            PBBullet3.Visible = True
            PBBullet4.Visible = True
            PBBullet5.Visible = False
            PBBullet6.Visible = False
            Points = Points + 200
        ElseIf FireChances = 1 And LoadBullet <> FireChances Then
            PBBullet1.Visible = True
            PBBullet2.Visible = True
            PBBullet3.Visible = True
            PBBullet4.Visible = True
            PBBullet5.Visible = True
            PBBullet6.Visible = False
            Points = Points + 100
        End If

        FireChances = FireChances + 1
    End Sub

    Private Sub Button()
        If btnLoadBullet.Enabled Then
            pbChamber.Image = My.Resources.Chamber_1
            btnSpinChamber.Enabled = True
            btnLoadBullet.Enabled = False
        ElseIf btnSpinChamber.Enabled Then
            btnSpinChamber.Enabled = False
            btnLoadBullet.Enabled = False
            btnFire.Enabled = True
            btnShotAway.Enabled = True
        End If
    End Sub

    Private Sub BulletHide()
        If PBBullet1.Visible = True And PBBullet2.Visible = True And PBBullet3.Visible = True And PBBullet4.Visible = True And PBBullet5.Visible = True And PBBullet6.Visible = True Then
            PBBullet6.Visible = False
        ElseIf PBBullet1.Visible = True And PBBullet2.Visible = True And PBBullet3.Visible = True And PBBullet4.Visible = True And PBBullet5.Visible = True And PBBullet6.Visible = False Then
            PBBullet5.Visible = False
        ElseIf PBBullet1.Visible = True And PBBullet2.Visible = True And PBBullet3.Visible = True And PBBullet4.Visible = True And PBBullet5.Visible = False And PBBullet6.Visible = False Then
            PBBullet4.Visible = False
        ElseIf PBBullet1.Visible = True And PBBullet2.Visible = True And PBBullet3.Visible = True And PBBullet4.Visible = False And PBBullet5.Visible = False And PBBullet6.Visible = False Then
            PBBullet3.Visible = False
        ElseIf PBBullet1.Visible = True And PBBullet2.Visible = True And PBBullet3.Visible = False And PBBullet4.Visible = False And PBBullet5.Visible = False And PBBullet6.Visible = False Then
            PBBullet2.Visible = False
        ElseIf PBBullet1.Visible = True And PBBullet2.Visible = False And PBBullet3.Visible = False And PBBullet4.Visible = False And PBBullet5.Visible = False And PBBullet6.Visible = False Then
            PBBullet1.Visible = False
        End If
    End Sub

End Class