<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resetpassword = New System.Windows.Forms.LinkLabel()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.SignIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User name"
        '
        'resetpassword
        '
        Me.resetpassword.AutoSize = True
        Me.resetpassword.Location = New System.Drawing.Point(206, 187)
        Me.resetpassword.Name = "resetpassword"
        Me.resetpassword.Size = New System.Drawing.Size(86, 13)
        Me.resetpassword.TabIndex = 1
        Me.resetpassword.TabStop = True
        Me.resetpassword.Text = "Forgot Password"
        '
        'TxtUname
        '
        Me.TxtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUname.Location = New System.Drawing.Point(234, 12)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(238, 26)
        Me.TxtUname.TabIndex = 1
        '
        'TxtPwd
        '
        Me.TxtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwd.Location = New System.Drawing.Point(234, 54)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.Size = New System.Drawing.Size(238, 26)
        Me.TxtPwd.TabIndex = 2
        Me.TxtPwd.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'SignUp
        '
        Me.SignUp.BackgroundImage = Global.ItecReg_pro_.My.Resources.Resources.SignUp2
        Me.SignUp.Location = New System.Drawing.Point(13, 116)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(196, 68)
        Me.SignUp.TabIndex = 7
        Me.SignUp.UseVisualStyleBackColor = True
        '
        'SignIn
        '
        Me.SignIn.BackgroundImage = Global.ItecReg_pro_.My.Resources.Resources.LoginBtn
        Me.SignIn.Location = New System.Drawing.Point(289, 116)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(193, 68)
        Me.SignIn.TabIndex = 6
        Me.SignIn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ItecReg_pro_.My.Resources.Resources.login1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 212)
        Me.Controls.Add(Me.SignUp)
        Me.Controls.Add(Me.SignIn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUname)
        Me.Controls.Add(Me.resetpassword)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 250)
        Me.MinimumSize = New System.Drawing.Size(500, 250)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents resetpassword As LinkLabel
    Friend WithEvents TxtUname As TextBox
    Friend WithEvents TxtPwd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SignIn As Button
    Friend WithEvents SignUp As Button
End Class
