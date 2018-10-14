Imports System.ComponentModel
Public Class Booking

#Region "Private Variables"

#End Region

#Region "Public Properties"
    Public Property Cinema As String
    Public Property ShowTime As String
    Public Property Movie As String
    Public Property Seats As String
    Public Property Total As Double
#End Region

#Region "Methods"
    Public Sub New(aCinema As String, aShowTime As String, aMovie As String, aSeats As String)
        Cinema = aCinema
        ShowTime = aShowTime
        Movie = aMovie
        Seats = aSeats
    End Sub

    Public Sub calculatePrice(numTickets As Integer)
        Total = numTickets * 50
    End Sub
#End Region

End Class

