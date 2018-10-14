Public Class LogIN
    Public Property i As Integer = 0
    Public Property tempUserlist As New UserList

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click

        Dim userPassword As String = txtLogInPassword.Text
        Dim passwordCheck As Boolean
        For Each aUser As User In tempUserlist

            If txtEmailLogIn.Text = aUser.Email Then
                passwordCheck = aUser.CheckLogin(userPassword)
                If passwordCheck = True Then
                    Me.Close()
                Else
                    MsgBox("Password incorrect", MsgBoxStyle.Exclamation)
                End If
            Else
                i = i + 1
            End If
        Next
    End Sub


    Private Sub txtLogInPassword_TextChanged(sender As Object, e As EventArgs) Handles txtLogInPassword.TextChanged

    End Sub
End Class