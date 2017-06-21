Public Class Login
    Dim result As Integer
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        If TxtUname.Text = "" And TxtPwd.Text = "" Then
            result = MessageBox.Show("All fields are required please try again", "Invalid Login", MessageBoxButtons.RetryCancel)
            If result = DialogResult.Retry Then
                Me.Show()
                TxtUname.Focus()
            End If
        ElseIf TxtUname.Text = "" Then
            result = MessageBox.Show("All fields are required please try again", "Invalid Login", MessageBoxButtons.RetryCancel)
            If result = DialogResult.Retry Then
                Me.Show()
                TxtUname.Focus()
            Else
                Me.Close()

            End If
        End If
    End Sub
End Class