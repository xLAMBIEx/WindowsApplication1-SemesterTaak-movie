Public Class Form1
    Dim aUsers As New UserList
    Dim aShowTimes As New ShowtimeList
    Dim aBookings As New BookingList
    Dim aMovies As New MovieList
    Dim aCinemas As New CinemaList
    Dim CurrentUser As Integer = -1
    Dim numUsers As Integer = aUsers.Count

    Private Sub CreateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAccountToolStripMenuItem.Click
        Dim frmCreateAccount As New CreateAccount

        frmCreateAccount.ShowDialog()
        aUsers.Add(frmCreateAccount.tempUser)

        CurrentUser = numUsers
        numUsers = numUsers + 1
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Dim frmLogIn As New LogIN

        If CurrentUser = -1 Then
            frmLogIn.tempUserlist = aUsers
            frmLogIn.ShowDialog()
            CurrentUser = frmLogIn.i
        Else
            MsgBox("Already logged in!")
        End If
    End Sub

    Private Sub NowShowingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NowShowingToolStripMenuItem.Click
        Dim frmNowShowing As New NowShowing

        If CurrentUser <> -1 Then
            frmNowShowing.ShowDialog()
            aUsers(CurrentUser).Bookings.Add(frmNowShowing.aBooking)
        Else
            MsgBox("Please Log In first!", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

        If CurrentUser <> -1 Then
            MsgBox("You have successfully logged out.", MsgBoxStyle.Information)
            CurrentUser = -1
        Else
            MsgBox("Please Log In first!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub ViewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAccountToolStripMenuItem.Click
        Dim frmView As New ViewAccount

        If CurrentUser <> -1 Then
            frmView.aUser = aUsers(CurrentUser)

            frmView.ShowDialog()
        Else
            MsgBox("Please Log In first!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
