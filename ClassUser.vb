Imports System
Imports System.Collections.Generic
Imports System.Diagnostics

Namespace PTOApp

    ' Superclass User
    Public Class User
        Protected SIN As Integer
        Protected LName As String
        Protected FName As String
        Protected DOB As DateTime
        Protected Address As String
        Protected Email As String
        Protected Phone As String
        Protected StartDate As DateTime
        Protected EndDate As DateTime
        Public Property ShowingWeeklySchedule As List(Of String)
        Public Property ConfirmationSelection As Boolean
        Public Property ScheduleView As List(Of String)
        Public Property ConfirmationReception As Boolean

        ' User constructor
        Public Sub New(sin As Integer, lname As String, fname As String, dob As DateTime, address As String, email As String, phone As String, startDate As DateTime, endDate As DateTime)
            sin = sin
            lname = lname
            fname = fname
            dob = dob
            address = address
            email = email
            phone = phone
            startDate = startDate
            endDate = endDate
            ShowingWeeklySchedule = New List(Of String)() ' empty
            ScheduleView = New List(Of String)() ' empty
        End Sub

        ' methods
        Public Sub ViewPTOHistory(EmpID As Integer)
            ' Define the path to the PTOHistory.vb file and open "PTOHistory.vb" window
            Dim filePath As String = "C:\path\to\PTOHistory.vb"

            Try
                ' Use Process.Start to open the file with the default application
                Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
            Catch ex As Exception
                ' Handles exceptions
                Console.WriteLine("Unable to open the file. Error: " & ex.Message)
            End Try
        End Sub

        'login purposes for DBHandler.cs

    End Class
End Namespace


