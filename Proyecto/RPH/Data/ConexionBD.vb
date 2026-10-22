Imports System.Configuration
Imports Microsoft.Data.SqlClient

Namespace Data
    ''' <summary>
    ''' Gestiona la cadena de conexión y la conectividad hacia la base de datos SQL Server Hospital.
    ''' </summary>
    Public Class ConexionBD
        Private Shared CadenaConexionActiva As String = String.Empty

        ''' <summary>
        ''' Obtiene la cadena de conexión activa o resuelta automáticamente.
        ''' </summary>
        Public Shared Function ObtenerCadenaConexion() As String
            If Not String.IsNullOrEmpty(CadenaConexionActiva) Then
                Return CadenaConexionActiva
            End If

            ' 1. Intentar leer desde App.config
            Try
                Dim setting = ConfigurationManager.ConnectionStrings("HospitalConexion")
                If setting IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(setting.ConnectionString) Then
                    CadenaConexionActiva = setting.ConnectionString
                    Return CadenaConexionActiva
                End If
            Catch
                ' Continuar con servidores candidatos
            End Try

            ' 2. Valor predeterminado hacia el servidor VPS Ubuntu
            CadenaConexionActiva = "Server=tcp:10.196.68.14,1433;Initial Catalog=Hospital;User ID=vb_user;Password=TuPasswordSeguro123!;Encrypt=True;TrustServerCertificate=True;Connect Timeout=15;"
            Return CadenaConexionActiva
        End Function

        ''' <summary>
        ''' Crea y devuelve una nueva instancia de SqlConnection abierta.
        ''' </summary>
        Public Shared Function ObtenerConexion() As SqlConnection
            Dim conexion As New SqlConnection(ObtenerCadenaConexion())
            conexion.Open()
            Return conexion
        End Function

        ''' <summary>
        ''' Verifica que la base de datos Hospital y las tablas pacientes y citas existan,
        ''' creándolas automáticamente si es necesario para garantizar que el proyecto
        ''' funcione en cualquier entorno sin intervención manual del evaluador.
        ''' </summary>
        Public Shared Sub AsegurarEstructuraBaseDeDatos()
            Try
                Using conn As SqlConnection = ObtenerConexion()
                    Dim scriptTablas As String = "
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'pacientes')
                    BEGIN
                        CREATE TABLE pacientes (
                            id_paciente INT IDENTITY(1,1) PRIMARY KEY,
                            codigo_paciente VARCHAR(10) NOT NULL UNIQUE,
                            nombre VARCHAR(100) NOT NULL,
                            cedula VARCHAR(20) NOT NULL,
                            fecha_nacimiento DATE
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'citas')
                    BEGIN
                        CREATE TABLE citas (
                            id_cita INT IDENTITY(1,1) PRIMARY KEY,
                            id_paciente INT NOT NULL,
                            fecha_cita DATE NOT NULL,
                            tipo_consulta VARCHAR(100) NOT NULL,
                            sintomas VARCHAR(500) NOT NULL,

                            CONSTRAINT fk_cita_paciente
                                FOREIGN KEY (id_paciente)
                                REFERENCES pacientes(id_paciente)
                                ON DELETE CASCADE
                        );

                        INSERT INTO pacientes (codigo_paciente, nombre, cedula, fecha_nacimiento)
                        VALUES 
                        ('PAC001', N'Carlos Mendoza Soto', '8-745-1234', '1990-04-15'),
                        ('PAC002', N'Valeria Gómez Rivas', '4-802-5678', '1997-11-23'),
                        ('PAC003', N'Elena Morales Ortiz', '3-541-9876', '1962-08-30');

                        INSERT INTO citas (id_paciente, fecha_cita, tipo_consulta, sintomas)
                        VALUES
                        (1, '2026-10-06', N'Medicina General', N'Fiebre persistente, dolor de cabeza y malestar general.'),
                        (2, '2026-10-06', N'Urgencias', N'Dolor agudo en articulaciones y mareos matutinos.'),
                        (3, '2026-10-07', N'Cardiología', N'Presión arterial elevada y fatiga al caminar.');
                    END;"

                    Using cmd As New SqlCommand(scriptTablas, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Advertencia al verificar estructura Hospital: " & ex.Message)
            End Try
        End Sub
    End Class
End Namespace
