Public NotInheritable Class Form1
    Private Sub Form1_Paint(ByVal sender As Object,
     ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath
        Dim intval As Integer
        Dim cirOrec As Integer
        cirOrec = 0
        If intval = 0 Then
            intval = 90
        End If
        Dim chgcorn As Integer = intval
        If chgcorn Mod 10 <> 0 Then
            chgcorn = chgcorn - (chgcorn Mod 10)
        End If
        Dim r1 As New Rectangle(0, Me.Height - chgcorn, chgcorn, chgcorn)
        Dim r2 As New Rectangle(Me.Width - chgcorn + 1,
                Me.Height - chgcorn, chgcorn, chgcorn)
        'the upper Arc
        gp.AddArc(0, 0, chgcorn, chgcorn, 180, 90)
        gp.AddArc(Me.Width - chgcorn + 1, 0, chgcorn, chgcorn, 270, 90)
        ' the Body
        gp.AddRectangle(New Rectangle(0, chgcorn / 2, Me.Width, Me.Height - chgcorn))
        'the lower Arc
        gp.AddArc(r1, -270, 90)
        gp.AddArc(r2, 360, 90)
        Region = New Region(gp)
        Me.LblCopyright.Text = "Copyright © " & Now.Year
        Me.LblVersion.Text = "Version " & My.Application.Info.Version.ToString()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Increment(1)
        Me.LblLevel.Text = "Loading . . " & ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class
