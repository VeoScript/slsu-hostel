Public Class AddUserAccount
    Private Sub btnCreateUserAccount_Click(sender As Object, e As EventArgs) Handles btnCreateUserAccount.Click
        CreateAccount1.Visible = True
        DeleteAccount1.Visible = False
    End Sub

    Private Sub btnDeleteUserAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteUserAccount.Click
        CreateAccount1.Visible = False
        DeleteAccount1.Visible = True
    End Sub
End Class
