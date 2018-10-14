Public Class CreateAccount
    Public Property tempUser As User

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtCreatePassword.Text = txtConfirmPassword.Text Then

            Dim aUser As New User(txtConfirmPassword.Text)

            Dim sName, sSurname As String
            Dim sNameSurname As String = txtNameSurname.Text
            Dim i As Integer = sNameSurname.IndexOf(" ")

            sName = sNameSurname.Substring(0, i)
            sSurname = sNameSurname.Substring(i + 1)
            aUser.Email = txtEmail.Text
            aUser.Name = sName
            aUser.Surname = sSurname
            tempUser = aUser
            Me.Close()
        Else
            MsgBox("Password does not match!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class