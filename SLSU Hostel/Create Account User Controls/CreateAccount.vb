Imports System.Data.SqlClient
Public Class CreateAccount

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        con = New SqlConnection
        con.ConnectionString = ConString()

        Try
            If cmbAccountType.SelectedItem = "" Then
                MessageBox.Show("Please select your Account Type first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbAccountType.Focus()
            ElseIf txtName.Text = "" Then
                MessageBox.Show("Please enter you Name first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtName.Focus()
            ElseIf cmbPosition.SelectedItem = "" Then
                MessageBox.Show("Please select your Position first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbPosition.Focus()
            ElseIf txtUsername.Text = "" Then
                MessageBox.Show("Please enter your Username first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MessageBox.Show("Please enter your Password first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Focus()
            ElseIf txtReEnterPassword.Text = "" Then
                MessageBox.Show("Please enter your Password in this text field first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtReEnterPassword.Focus()
            ElseIf txtPassword.Text <> txtReEnterPassword.Text Then
                MessageBox.Show("Your Password did not matched! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtReEnterPassword.Text = ""
                txtPassword.Focus()
            Else
                con.Open()
                Dim querySelect As String
                querySelect = "SELECT * FROM account WHERE fullname='" & txtName.Text & "' OR username='" & txtUsername.Text & "'"
                cmd = New SqlCommand(querySelect, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MessageBox.Show("This accout is Already Exist! Check your Name and Username.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    con.Close()
                    con.Open()
                    Dim queryInsert As String
                    queryInsert = "INSERT INTO account(accounttype, fullname, position, username, password) VALUES('" & cmbAccountType.SelectedItem & "', '" & txtName.Text & "', '" & cmbPosition.SelectedItem & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "')"
                    cmd = New SqlCommand(queryInsert, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Home.AddUserAccount1.DeleteAccount1.dgUserAccounts.Refresh()
                    cmbAccountType.SelectedIndex = -1
                    txtName.Text = ""
                    cmbPosition.SelectedIndex = -1
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtReEnterPassword.Text = ""
                End If
                con.Close()

                'Refreshing User Account DataGridView
                con.Open()
                Dim query As String
                query = "SELECT accounttype AS 'Account Type', fullname AS 'Name', position AS 'Position', username AS 'Username' FROM account"
                cmd = New SqlCommand(query, con)

                adapter = New SqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                Home.AddUserAccount2.DeleteAccount1.dgUserAccounts.DataSource = table
                Home.AddUserAccount2.DeleteAccount1.dgUserAccounts.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtReEnterPassword.KeyDown, txtPassword.KeyDown, txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnCreate_Click(sender, e)
        End If
    End Sub
End Class
