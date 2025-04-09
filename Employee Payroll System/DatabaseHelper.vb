Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class DatabaseHelper
    ' Database connection string (can be moved to app.config)
    Private Shared ReadOnly ConnectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"

    ' Execute a query that returns a DataTable
    Public Shared Function ExecuteQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(ConnectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Add parameters if they exist
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.Add(param)
                        Next
                    End If

                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            Catch ex As Exception
                ' Log the error (you could add logging here)
                Throw New Exception("Database query error: " & ex.Message, ex)
            End Try
        End Using

        Return dataTable
    End Function

    ' Execute a non-query (INSERT, UPDATE, DELETE)
    Public Shared Function ExecuteNonQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim rowsAffected As Integer = 0

        Using connection As New SqlConnection(ConnectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Add parameters if they exist
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.Add(param)
                        Next
                    End If

                    rowsAffected = command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                ' Log the error
                Throw New Exception("Database non-query error: " & ex.Message, ex)
            End Try
        End Using

        Return rowsAffected
    End Function

    ' Execute a scalar query (returns single value)
    Public Shared Function ExecuteScalar(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Object
        Dim result As Object = Nothing

        Using connection As New SqlConnection(ConnectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Add parameters if they exist
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.Add(param)
                        Next
                    End If

                    result = command.ExecuteScalar()
                End Using
            Catch ex As Exception
                ' Log the error
                Throw New Exception("Database scalar error: " & ex.Message, ex)
            End Try
        End Using

        Return result
    End Function

    ' Get a new database connection
    Public Shared Function GetConnection() As SqlConnection
        Dim connection As New SqlConnection(ConnectionString)
        Try
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw New Exception("Failed to open database connection: " & ex.Message, ex)
        End Try
    End Function

    ' Create a SQL parameter
    Public Shared Function CreateParameter(name As String, value As Object, Optional dbType As SqlDbType = SqlDbType.NVarChar) As SqlParameter
        Return New SqlParameter(name, dbType) With {
            .value = If(value Is Nothing, DBNull.Value, value)
        }
    End Function

    ' Begin a transaction
    Public Shared Function BeginTransaction(connection As SqlConnection) As SqlTransaction
        Return connection.BeginTransaction()
    End Function
End Class