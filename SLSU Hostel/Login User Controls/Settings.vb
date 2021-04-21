Imports System.Data.SqlClient
Public Class Settings

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        If txtDataSource.Text = "" Then
            MsgBox("Please Enter Data Source First!")
            txtDataSource.Focus()
        ElseIf txtDatabaseName.Text = "" Then
            MsgBox("Please Enter Database First!")
            txtDatabaseName.Focus()
        Else
            ConnectionStringModule.DataSouceString = txtDataSource.Text
            ConnectionStringModule.DatabaseString = txtDatabaseName.Text
            MsgBox("Connection Connected Successfully!")
            txtDataSource.Text = ""
            txtDatabaseName.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""

            Login.UserLogin1.Visible = True
            Login.Settings1.Visible = False
            Login.About1.Visible = False
        End If
    End Sub

    Private Sub btnSaveConnection_Click(sender As Object, e As EventArgs) Handles btnSaveConnection.Click
        If txtDataSource.Text = "" Then
            MsgBox("Please Enter Data Source First!")
            txtDataSource.Focus()
        ElseIf txtDatabaseName.Text = "" Then
            MsgBox("Please Enter Database First!")
            txtDatabaseName.Focus()
        Else
            ConnectionStringModule.DataSouceString = txtDataSource.Text
            ConnectionStringModule.DatabaseString = txtDatabaseName.Text
            MsgBox("Save Successfully!")
            txtDataSource.Text = ""
            txtDatabaseName.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""

            Login.UserLogin1.Visible = True
            Login.Settings1.Visible = False
            Login.About1.Visible = False
        End If
    End Sub

    Private Sub txtDataSource_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown, txtDataSource.KeyDown, txtDatabaseName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnTestConnection_Click(sender, e)
        End If
    End Sub
End Class
