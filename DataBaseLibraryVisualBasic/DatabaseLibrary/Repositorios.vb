Imports System.Data
Imports Database.Connection
Imports Database.Modelos
Imports Microsoft.Data.SqlClient



Namespace Database.Repositorios
    Public Class PacientesRepositorio

        Private ReadOnly _connection As DatabaseConnection

        Public Sub New(connectionString As String)
            _connection = New DatabaseConnection(connectionString)
        End Sub

        Public Function GetPacientes() As DataTable

            Dim pacientes As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
                    "SELECT * FROM pacientes"

                    Using command As New SqlCommand(
                        sql,
                        connection)

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(pacientes)
                        End Using

                    End Using
                End Using
            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try


            Return pacientes

        End Function

        Public Function GetByPacienteId(idPaciente As Integer) As DataTable

            Dim paciente As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
            "SELECT * " &
            "FROM pacientes " &
            "WHERE id_paciente = @idPaciente "

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue(
                "@idPaciente",
                idPaciente
            )

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(paciente)
                        End Using

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return paciente

        End Function

        Public Function GetByPacienteCod(codigoPaciente As String) As DataTable

            Dim paciente As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
            "SELECT * FROM pacientes " &
            "WHERE CodigoPaciente = @codigo "

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue(
                "@codigo",
                codigoPaciente
            )

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(paciente)
                        End Using

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return paciente

        End Function


        Public Function AddPaciente(p As Paciente) As Boolean

            Try
                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
                        "INSERT INTO pacientes " &
                        "(codigo_paciente, nombre, cedula, fecha_nacimiento, sexo) " &
                        "VALUES " &
                        "(@codigo, @nombre, @cedula, @fechaNacimiento, @sexo)"

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue("@codigo", p.CodigoPaciente)
                        command.Parameters.AddWithValue("@nombre", p.Nombre)
                        command.Parameters.AddWithValue("@cedula", p.Cedula)
                        command.Parameters.AddWithValue("@sexo", p.Sexo)

                        If p.FechaNacimiento.HasValue Then
                            command.Parameters.AddWithValue(
                                "@fechaNacimiento",
                                p.FechaNacimiento.Value
                            )
                        Else
                            command.Parameters.AddWithValue(
                                "@fechaNacimiento",
                                DBNull.Value
                            )
                        End If

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        Return rowsAffected > 0

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return False

        End Function



    End Class


    Public Class CitasRepositorio

        Private ReadOnly _connection As DatabaseConnection

        Public Sub New(connectionString As String)
            _connection = New DatabaseConnection(connectionString)
        End Sub

        Public Function GetCitasByPacienteId(idPaciente As Integer) As DataTable

            Dim citas As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
            "SELECT * " &
            "FROM citas " &
            "WHERE id_paciente = @idPaciente " &
            "ORDER BY fecha_cita"

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue(
                "@idPaciente",
                idPaciente
            )

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(citas)
                        End Using

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return citas

        End Function

        Public Function GetCitasByPacienteCod(codigoPaciente As String) As DataTable

            Dim citas As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
            "SELECT * " &
            "FROM citas " &
            "WHERE CodigoPaciente = @codigo " &
            "ORDER BY fecha_cita"

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue(
                "@codigo",
                codigoPaciente
            )

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(citas)
                        End Using

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return citas

        End Function


        Public Function GetCitas() As DataTable

            Dim citas As New DataTable()

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
                    "SELECT * FROM citas"

                    Using command As New SqlCommand(
                        sql,
                        connection)

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(citas)
                        End Using

                    End Using
                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return citas

        End Function


        Public Function AddCita(c As Cita) As Boolean

            Try

                Using connection = _connection.GetConnection()

                    connection.Open()

                    Dim sql As String =
                    "INSERT INTO citas " &
                    "(id_paciente, fecha_cita, tipo_consulta, sintomas ) " &
                    "VALUES " &
                    "(@idPaciente, @fechaCita, @tipoConsulta, @sintomas)"

                    Using command As New SqlCommand(sql, connection)

                        command.Parameters.AddWithValue(
                    "@idPaciente",
                    c.IdPaciente
                )

                        command.Parameters.AddWithValue(
                    "@fechaCita",
                    c.FechaCita.ToDateTime(TimeOnly.MinValue)
                )
                        command.Parameters.AddWithValue(
                    "@tipoConsulta",
                    c.TipoConsulta
                )
                        command.Parameters.AddWithValue(
                    "@sintomas",
                    c.Sintomas
                )

                        Dim rowsAffected As Integer =
                    command.ExecuteNonQuery()

                        Return rowsAffected > 0

                    End Using

                End Using

            Catch ex As SqlException

                Console.WriteLine("Error en la base de datos:")
                Console.WriteLine(ex.Message)

            Catch ex As Exception

                Console.WriteLine("Error:")
                Console.WriteLine(ex.Message)

            End Try

            Return False

        End Function

    End Class

End Namespace
