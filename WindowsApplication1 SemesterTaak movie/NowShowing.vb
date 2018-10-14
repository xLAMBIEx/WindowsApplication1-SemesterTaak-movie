Public Class NowShowing

    Public Property aBooking As Booking

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim sCinema As String = ""

        If radCinema1.Checked Then
            sCinema = radCinema1.Text
        ElseIf radCinema2.Checked Then
            sCinema = radCinema2.Text
        End If

        Dim tempBooking As New Booking(sCinema, lbxShowTime.SelectedItem, lbxMovies.SelectedItem, "Seats")

        aBooking = tempBooking
        aBooking.calculatePrice(numTickets.Value)
        MsgBox("Booking Created")

        Me.Close()
    End Sub

End Class