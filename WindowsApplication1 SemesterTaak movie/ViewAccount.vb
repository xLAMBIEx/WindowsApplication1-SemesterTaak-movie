Public Class ViewAccount
    Public Property aUser As User

    Private Sub ViewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = lblName.Text & aUser.Name
        lblSurname.Text = lblSurname.Text & aUser.Surname
        lblEmail.Text = lblEmail.Text & aUser.Email

        For Each aBooking As Booking In aUser.Bookings
            lbxBookings.Items.Add(aBooking.ShowTime & " " & aBooking.Movie & " " & aBooking.Seats & " Tickets R" & aBooking.Total)
        Next

    End Sub
End Class