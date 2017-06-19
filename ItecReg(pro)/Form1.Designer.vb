<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 193)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(517, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 0
        '
        'LblLevel
        '
        Me.LblLevel.AutoSize = True
        Me.LblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevel.Location = New System.Drawing.Point(10, 167)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(0, 24)
        Me.LblLevel.TabIndex = 1
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(399, 219)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(0, 24)
        Me.LblVersion.TabIndex = 2
        '
        'LblCopyright
        '
        Me.LblCopyright.AutoSize = True
        Me.LblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCopyright.Location = New System.Drawing.Point(10, 219)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(0, 24)
        Me.LblCopyright.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 262)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblLevel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblLevel As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblCopyright As Label
    Friend WithEvents Timer1 As Timer
End Class
