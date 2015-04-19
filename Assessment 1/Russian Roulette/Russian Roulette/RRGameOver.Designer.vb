<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RRGameOver
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
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPName = New System.Windows.Forms.Label()
        Me.lblPScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(27, 14)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(321, 56)
        Me.lblGameOver.TabIndex = 0
        Me.lblGameOver.Text = "GAME OVER!"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(222, 75)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(108, 36)
        Me.lblPlayerName.TabIndex = 1
        Me.lblPlayerName.Text = "Label2"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(222, 111)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(108, 36)
        Me.lblPlayerScore.TabIndex = 2
        Me.lblPlayerScore.Text = "Label3"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(105, 161)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(190, 79)
        Me.btnPlayAgain.TabIndex = 3
        Me.btnPlayAgain.Text = "PLAY AGAIN"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btnHighScore
        '
        Me.btnHighScore.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.Location = New System.Drawing.Point(105, 246)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(190, 79)
        Me.btnHighScore.TabIndex = 4
        Me.btnHighScore.Text = "VIEW HIGH SCORE"
        Me.btnHighScore.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(105, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 79)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPName
        '
        Me.lblPName.AutoSize = True
        Me.lblPName.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPName.Location = New System.Drawing.Point(12, 75)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(204, 36)
        Me.lblPName.TabIndex = 6
        Me.lblPName.Text = "Player Name:"
        '
        'lblPScore
        '
        Me.lblPScore.AutoSize = True
        Me.lblPScore.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPScore.Location = New System.Drawing.Point(12, 111)
        Me.lblPScore.Name = "lblPScore"
        Me.lblPScore.Size = New System.Drawing.Size(199, 36)
        Me.lblPScore.TabIndex = 7
        Me.lblPScore.Text = "Player Score:"
        '
        'RRGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 415)
        Me.Controls.Add(Me.lblPScore)
        Me.Controls.Add(Me.lblPName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblGameOver)
        Me.Name = "RRGameOver"
        Me.Text = "Russian Roulette: Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents btnHighScore As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents lblPScore As System.Windows.Forms.Label
End Class
