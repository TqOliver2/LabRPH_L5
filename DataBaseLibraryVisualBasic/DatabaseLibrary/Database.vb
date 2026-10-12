Imports Microsoft.Data.SqlClient


Namespace Database.Connection
    Public Class DatabaseConnection

        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        Public Function GetConnection() As SqlConnection
            Return New SqlConnection(_connectionString)
        End Function

        Public Function CheckConnection() As SqlConnection
            Return New SqlConnection(_connectionString)
        End Function

    End Class

End Namespace

