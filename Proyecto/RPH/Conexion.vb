Imports System.Configuration
Imports Microsoft.Data.SqlClient

''' <summary>
''' Módulo central de conexión con la base de datos SQL Server Hospital.
''' Proporciona el método ObtenerConexion() según la guía de laboratorio.
''' </summary>
Public Module Conexion

    Public Function ObtenerConexion() As SqlConnection

        ' 1. Intentar leer desde App.config si está configurado
        Try
            Dim setting = ConfigurationManager.ConnectionStrings("HospitalConexion")
            If setting IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(setting.ConnectionString) Then
                Return New SqlConnection(setting.ConnectionString)
            End If
        Catch
        End Try

        ' 2. Cadena predeterminada hacia el servidor VPS Ubuntu
        Dim cadenaDefecto As String =
            "Server=tcp:10.196.68.14,1433;" &
            "Initial Catalog=Hospital;" &
            "User ID=vb_user;Password=TuPasswordSeguro123!;" &
            "Encrypt=True;TrustServerCertificate=True;Connect Timeout=15;"

        Return New SqlConnection(cadenaDefecto)

    End Function

End Module
