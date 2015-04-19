<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RRGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GBOptions = New System.Windows.Forms.GroupBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnShotAway = New System.Windows.Forms.Button()
        Me.btnLoadBullet = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnSpinChamber = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbGunControls = New System.Windows.Forms.GroupBox()
        Me.pbChamber = New System.Windows.Forms.PictureBox()
        Me.PBBullet6 = New System.Windows.Forms.PictureBox()
        Me.PBBullet1 = New System.Windows.Forms.PictureBox()
        Me.PBBullet5 = New System.Windows.Forms.PictureBox()
        Me.PBBullet3 = New System.Windows.Forms.PictureBox()
        Me.PBBullet4 = New System.Windows.Forms.PictureBox()
        Me.PBBullet2 = New System.Windows.Forms.PictureBox()
        Me.pbGun = New System.Windows.Forms.PictureBox()
        Me.GBOptions.SuspendLayout()
        Me.gbGunControls.SuspendLayout()
        CType(Me.pbChamber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBOptions
        '
        Me.GBOptions.Controls.Add(Me.lblUserName)
        Me.GBOptions.Controls.Add(Me.btnHighScore)
        Me.GBOptions.Controls.Add(Me.btnQuit)
        Me.GBOptions.Controls.Add(Me.btnNewGame)
        Me.GBOptions.Location = New System.Drawing.Point(4, 313)
        Me.GBOptions.Name = "GBOptions"
        Me.GBOptions.Size = New System.Drawing.Size(274, 134)
        Me.GBOptions.TabIndex = 15
        Me.GBOptions.TabStop = False
        Me.GBOptions.Text = "Options"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(10, 16)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(61, 21)
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "Label1"
        '
        'btnHighScore
        '
        Me.btnHighScore.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.Location = New System.Drawing.Point(122, 40)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(124, 35)
        Me.btnHighScore.TabIndex = 8
        Me.btnHighScore.Text = "HIGH SCORE"
        Me.btnHighScore.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(6, 81)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(110, 35)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(6, 40)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(110, 35)
        Me.btnNewGame.TabIndex = 5
        Me.btnNewGame.Text = "NEW GAME"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnShotAway
        '
        Me.btnShotAway.Enabled = False
        Me.btnShotAway.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShotAway.Location = New System.Drawing.Point(159, 20)
        Me.btnShotAway.Name = "btnShotAway"
        Me.btnShotAway.Size = New System.Drawing.Size(124, 49)
        Me.btnShotAway.TabIndex = 7
        Me.btnShotAway.Text = "SHOT AWAY"
        Me.btnShotAway.UseVisualStyleBackColor = True
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBullet.Location = New System.Drawing.Point(15, 19)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(124, 49)
        Me.btnLoadBullet.TabIndex = 2
        Me.btnLoadBullet.Text = "LOAD BULLET"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Enabled = False
        Me.btnFire.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(159, 75)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(124, 48)
        Me.btnFire.TabIndex = 4
        Me.btnFire.Text = "FIRE!"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnSpinChamber
        '
        Me.btnSpinChamber.Enabled = False
        Me.btnSpinChamber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinChamber.Location = New System.Drawing.Point(15, 74)
        Me.btnSpinChamber.Name = "btnSpinChamber"
        Me.btnSpinChamber.Size = New System.Drawing.Size(124, 49)
        Me.btnSpinChamber.TabIndex = 3
        Me.btnSpinChamber.Text = "SPIN CHAMBER"
        Me.btnSpinChamber.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'gbGunControls
        '
        Me.gbGunControls.Controls.Add(Me.btnSpinChamber)
        Me.gbGunControls.Controls.Add(Me.btnFire)
        Me.gbGunControls.Controls.Add(Me.btnShotAway)
        Me.gbGunControls.Controls.Add(Me.btnLoadBullet)
        Me.gbGunControls.Location = New System.Drawing.Point(284, 313)
        Me.gbGunControls.Name = "gbGunControls"
        Me.gbGunControls.Size = New System.Drawing.Size(303, 134)
        Me.gbGunControls.TabIndex = 10
        Me.gbGunControls.TabStop = False
        Me.gbGunControls.Text = "Gun Controls"
        '
        'pbChamber
        '
        Me.pbChamber.Image = Global.Russian_Roulette.My.Resources.Resources.Chamber
        Me.pbChamber.Location = New System.Drawing.Point(10, 146)
        Me.pbChamber.Name = "pbChamber"
        Me.pbChamber.Size = New System.Drawing.Size(150, 150)
        Me.pbChamber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChamber.TabIndex = 39
        Me.pbChamber.TabStop = False
        '
        'PBBullet6
        '
        Me.PBBullet6.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet6.Location = New System.Drawing.Point(300, 261)
        Me.PBBullet6.Name = "PBBullet6"
        Me.PBBullet6.Size = New System.Drawing.Size(27, 35)
        Me.PBBullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet6.TabIndex = 45
        Me.PBBullet6.TabStop = False
        '
        'PBBullet1
        '
        Me.PBBullet1.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet1.Location = New System.Drawing.Point(166, 261)
        Me.PBBullet1.Name = "PBBullet1"
        Me.PBBullet1.Size = New System.Drawing.Size(28, 35)
        Me.PBBullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet1.TabIndex = 40
        Me.PBBullet1.TabStop = False
        '
        'PBBullet5
        '
        Me.PBBullet5.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet5.Location = New System.Drawing.Point(273, 261)
        Me.PBBullet5.Name = "PBBullet5"
        Me.PBBullet5.Size = New System.Drawing.Size(28, 35)
        Me.PBBullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet5.TabIndex = 44
        Me.PBBullet5.TabStop = False
        '
        'PBBullet3
        '
        Me.PBBullet3.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet3.Location = New System.Drawing.Point(220, 261)
        Me.PBBullet3.Name = "PBBullet3"
        Me.PBBullet3.Size = New System.Drawing.Size(28, 35)
        Me.PBBullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet3.TabIndex = 42
        Me.PBBullet3.TabStop = False
        '
        'PBBullet4
        '
        Me.PBBullet4.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet4.Location = New System.Drawing.Point(247, 261)
        Me.PBBullet4.Name = "PBBullet4"
        Me.PBBullet4.Size = New System.Drawing.Size(28, 35)
        Me.PBBullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet4.TabIndex = 43
        Me.PBBullet4.TabStop = False
        '
        'PBBullet2
        '
        Me.PBBullet2.Image = Global.Russian_Roulette.My.Resources.Resources.Bullet
        Me.PBBullet2.Location = New System.Drawing.Point(193, 261)
        Me.PBBullet2.Name = "PBBullet2"
        Me.PBBullet2.Size = New System.Drawing.Size(28, 35)
        Me.PBBullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBullet2.TabIndex = 41
        Me.PBBullet2.TabStop = False
        '
        'pbGun
        '
        Me.pbGun.Image = Global.Russian_Roulette.My.Resources.Resources.Gun
        Me.pbGun.Location = New System.Drawing.Point(10, 12)
        Me.pbGun.Name = "pbGun"
        Me.pbGun.Size = New System.Drawing.Size(574, 284)
        Me.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGun.TabIndex = 38
        Me.pbGun.TabStop = False
        '
        'RRGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 449)
        Me.Controls.Add(Me.pbChamber)
        Me.Controls.Add(Me.gbGunControls)
        Me.Controls.Add(Me.PBBullet6)
        Me.Controls.Add(Me.GBOptions)
        Me.Controls.Add(Me.PBBullet1)
        Me.Controls.Add(Me.PBBullet5)
        Me.Controls.Add(Me.PBBullet2)
        Me.Controls.Add(Me.PBBullet3)
        Me.Controls.Add(Me.PBBullet4)
        Me.Controls.Add(Me.pbGun)
        Me.Name = "RRGame"
        Me.Text = "Russian Roulette Game"
        Me.GBOptions.ResumeLayout(False)
        Me.GBOptions.PerformLayout()
        Me.gbGunControls.ResumeLayout(False)
        CType(Me.pbChamber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnHighScore As System.Windows.Forms.Button
    Friend WithEvents btnShotAway As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnLoadBullet As System.Windows.Forms.Button
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnSpinChamber As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents gbGunControls As System.Windows.Forms.GroupBox
    Friend WithEvents pbChamber As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet6 As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet1 As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet5 As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet3 As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet4 As System.Windows.Forms.PictureBox
    Friend WithEvents PBBullet2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbGun As System.Windows.Forms.PictureBox
End Class
