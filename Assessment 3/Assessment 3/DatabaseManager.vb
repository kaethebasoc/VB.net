Imports System.Data.SqlClient
Imports System.Data

Public Class DatabaseManager
    Dim SqlConn As New SqlConnection("Data Source=shar;Initial Catalog=Kaethe_Test;Integrated Security=True")
    Dim SqlStr As New SqlCommand
    Dim SqlReader As SqlDataReader
    Dim SqlStmt As String



    Public Sub AddCustomer(CustomerID As Int16, CustName As String, Address As String, Phone As Double, DOB As String)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Insert into Customer values ('" & CustomerID & "','" & CustName & "','" & Address & "','" & Phone & "','" & DOB & "')"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Function CustomersList(Name As String) As DataTable
        Dim DT As New DataTable
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Select * from Customer where Name like '%" & Name & "%'"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlReader = SqlStr.ExecuteReader()

            If SqlReader.HasRows Then
                DT.Load(SqlReader)
            End If

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
        Return DT
    End Function

    Public Sub DeleteCustomer(CustID As Integer)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Delete from Customer where CustID= " & CustID & ""
            SqlStr.CommandText = SqlStmt
            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateCustomer(CustID As Integer, Address As String, Phone As String)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Update Customer Set Address = '" & Address & "' , Phone = '" & Phone & "'where CustID='" & CustID & "'"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Function MovieList(Title As String) As DataTable
        Dim DT As New DataTable
        Try
            SqlStr.Connection = SqlConn
            ' SqlStmt = "Select * from Movies where Title like '%" & Title & "%'"
            SqlStmt = "Select * from Movies "
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlReader = SqlStr.ExecuteReader()

            If SqlReader.HasRows Then
                DT.Load(SqlReader)
            End If

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
        Return DT
    End Function

    Public Sub AddMovie(MovieID As Int16, Title As String, Genre As String, RentalCost As Double, ReleaseDate As String)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Insert into Movies values ('" & MovieID & "','" & Title & "','" & Genre & "','" & RentalCost & "','" & ReleaseDate & "')"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Sub DeleteMovie(MovieID As Integer)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Delete from Movies where MovieID= " & MovieID & ""
            SqlStr.CommandText = SqlStmt
            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateMovie(MovieID As Integer, Genre As String, RentalCost As Double, ReleaseDate As String)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Update Movies Set Genre = '" & Genre & "' , RentalCost = '" & RentalCost & "', ReleaseDate = '" & ReleaseDate & "'where MovieID='" & MovieID & "'"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
    End Sub

    Public Sub IssueMovie(MovieID As Integer, CustID As Integer)

        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Insert into RentedMovies(MovieID, CustomerID, DateRented) values('" & MovieID & "','" & CustID & "','" & Today & "')"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()

            SqlStmt = "Update Movies set Status = 'OUT' where MovieID =" & MovieID
            SqlStr.CommandText = SqlStmt
            SqlStr.ExecuteNonQuery()

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try

    End Sub

    Public Sub ReturnMovie(DateReturned As String, RentedMoviesID As Integer, MovieID As Integer)
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Update RentedMovies set DateReturned='" & DateReturned & "'where RentedMoviesID = " & RentedMoviesID
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlStr.ExecuteNonQuery()

            SqlStmt = "Update Movies set Status = 'IN' where MovieID =" & MovieID
            SqlStr.CommandText = SqlStmt
            SqlStr.ExecuteNonQuery()

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured" & ex.Message)
        End Try
    End Sub

    Public Function RentalList()
        Dim DT As New DataTable
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Select * from RentedMovies where DateReturned is NULL Order by RentedMoviesID"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlReader = SqlStr.ExecuteReader()

            If SqlReader.HasRows Then
                DT.Load(SqlReader)
            End If

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
        Return DT
    End Function

    Public Function Rented()
        Dim DT As New DataTable
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Select * from Movies M INNER JOIN RentedMovies R on M.MovieID = R.MovieID where DateReturned is NULL"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlReader = SqlStr.ExecuteReader()

            If SqlReader.HasRows Then
                DT.Load(SqlReader)
            End If

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
        Return DT
    End Function

    Public Function NotRented()
        Dim DT As New DataTable
        Try
            SqlStr.Connection = SqlConn
            SqlStmt = "Select * from Movies M LEFT OUTER JOIN RentedMovies R on M.MovieID = R.MovieID where Status ='IN'"
            SqlStr.CommandText = SqlStmt

            SqlConn.Open()
            SqlReader = SqlStr.ExecuteReader()

            If SqlReader.HasRows Then
                DT.Load(SqlReader)
            End If

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message)
        End Try
        Return DT
    End Function

End Class
