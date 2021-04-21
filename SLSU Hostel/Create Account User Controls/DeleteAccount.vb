Imports System.Data.SqlClient
Public Class DeleteAccount

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub DeleteAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection
        con.ConnectionString = ConString()

        Try
            con.Open()
            Dim query As String
            query = "SELECT accounttype AS 'Account Type', fullname AS 'Name', position AS 'Position', username AS 'Username' FROM account"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            dgUserAccounts.DataSource = table
            dgUserAccounts.Refresh()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgUserAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserAccounts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgUserAccounts.Rows(e.RowIndex)

            txtAccountType.Text = row.Cells("Account Type").Value.ToString
            txtName.Text = row.Cells("Name").Value.ToString
            txtPosition.Text = row.Cells("Position").Value.ToString
            txtUsername.Text = row.Cells("Username").Value.ToString
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAccountType.Text = "" Then
            MsgBox("No records found to be deleted!")
        Else
            txtAccountType.Text = ""
            txtName.Text = ""
            txtPosition.Text = ""
            txtUsername.Text = ""

            Dim DialogResult = MessageBox.Show("Are you sure you want to Delete this User Account?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Try
                    'Deleting User Account
                    con.Open()
                    cmd = New SqlCommand("DELETE FROM account WHERE fullname='" + txtName.Text + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("User Delete Successfully!")
                    txtAccountType.Text = ""
                    txtName.Text = ""
                    txtPosition.Text = ""
                    txtUsername.Text = ""
                    con.Close()

                    'Refreshing User Account DataGridView
                    con.Open()
                    Dim query As String
                    query = "SELECT accounttype AS 'Account Type', fullname AS 'Name', position AS 'Position', username AS 'Username' FROM account"
                    cmd = New SqlCommand(query, con)

                    adapter = New SqlDataAdapter(cmd)
                    table = New DataTable
                    adapter.Fill(table)

                    dgUserAccounts.DataSource = table
                    dgUserAccounts.Refresh()

                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Return
            End If
        End If
    End Sub
End Class
