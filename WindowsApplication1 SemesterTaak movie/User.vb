Imports System.ComponentModel
Public Class User

#Region "Private Variables"
        Private sPassword As String
        Private sEmail As String
        Private sName As String
        Private sSurname As String
        Private aBookings As New BookingList
#End Region

#Region "Public Properties"

    Public Property Email As String
        Get
            Return sEmail
        End Get
        Set(value As String)
            sEmail = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return sName
        End Get
        Set(value As String)
            sName = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return sSurname
        End Get
        Set(value As String)
            sSurname = value
        End Set
    End Property

    Public Property Bookings As BookingList
        Get
            Return aBookings
        End Get
        Set(value As BookingList)
            aBookings = value
        End Set
    End Property
#End Region


#Region "Methods"
        ' Public Sub New()
        '   Email = ""
        '  Name = ""
        ' Surname = ""
        'sPassword = ""
        'Bookings = New BindingList(Of Booking)
        'End Sub

    Public Sub New(aPassword As String)
        sPassword = aPassword
    End Sub

    Public Function CheckLogin(aPassword As String)
        If aPassword = sPassword Then
            Return True

        Else
            Return False
        End If
    End Function
#End Region

End Class

