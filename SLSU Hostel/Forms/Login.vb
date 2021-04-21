Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DialogResult = MessageBox.Show("Are you sure you want to close this system?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        Else
            Return
        End If
    End Sub

    Private Sub btnHomeLink_Click(sender As Object, e As EventArgs) Handles btnLoginLink.Click
        UserLogin1.Visible = True
        Settings1.Visible = False
        About1.Visible = False
    End Sub

    Private Sub btnSettingsLink_Click(sender As Object, e As EventArgs) Handles btnSettingsLink.Click
        UserLogin1.Visible = False
        Settings1.Visible = True
        About1.Visible = False
    End Sub

    Private Sub btnAboutLink_Click(sender As Object, e As EventArgs) Handles btnAboutLink.Click
        UserLogin1.Visible = False
        Settings1.Visible = False
        About1.Visible = True
    End Sub
End Class
