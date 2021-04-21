Imports System.Data.SqlClient
Public Class UserLogin

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con = New SqlConnection
        con.ConnectionString = ConString()

        Try
            If txtUsername.Text = "" Then
                MsgBox("Enter your Username first!")
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("Enter your Password first!")
                txtPassword.Focus()
            Else
                con.Open()
                Dim querySelect As String
                querySelect = "SELECT * FROM account WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
                cmd = New SqlCommand(querySelect, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    txtUsername.Text = ""
                    txtPassword.Text = ""

                    reader.Read()
                    Login.Hide()
                    Home.lblAccountType.Text = reader("accounttype").ToString
                    Home.lblName.Text = reader("fullname").ToString
                    Home.lblPosition.Text = reader("position").ToString
                    Home.lblUsername.Text = reader("username").ToString
                    Home.Show()
                    reader.Close()
                Else
                    MsgBox("Sorry this account doesn't exist! Check your Username or Password.")
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Focus()
                End If
                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
            MsgBox("Invalid Connection or Invalid Database!")
        End Try
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub
End Class
