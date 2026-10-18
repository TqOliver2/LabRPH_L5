Imports System.Data
Imports Microsoft.Data.SqlClient
Imports RPH.Models

Namespace Data
    ''' <summary>
    ''' Capa de Acceso a Datos (DAL) para las tablas 'pacientes' y 'citas' en la base de datos Hospital.
    ''' </summary>
    Public Class PacienteDAL

        ''' <summary>
        ''' Obtiene todos los pacientes con la información de su cita asociada para desplegar en el DataGridView.
        ''' </summary>
        Public Function ObtenerTodos() As DataTable
            Dim tabla As New DataTable()
            Dim consulta As String = "
                SELECT 
                    p.id_paciente AS [ID],
                    p.codigo_paciente AS [Código],
                    p.nombre AS [Nombre del Paciente],
                    p.cedula AS [Cédula],
                    p.fecha_nacimiento AS [FechaNacimiento],
                    FORMAT(p.fecha_nacimiento, 'dd/MM/yyyy') AS [F. Nacimiento],
                    (DATEDIFF(YEAR, p.fecha_nacimiento, GETDATE()) - 
                        CASE WHEN (DATEADD(YEAR, DATEDIFF(YEAR, p.fecha_nacimiento, GETDATE()), p.fecha_nacimiento) > GETDATE()) 
                             THEN 1 ELSE 0 END) AS [Edad],
                    ISNULL(c.id_cita, 0) AS [IDCita],
                    ISNULL(c.fecha_cita, GETDATE()) AS [FechaCita],
                    FORMAT(c.fecha_cita, 'dd/MM/yyyy') AS [Fecha Cita],
                    ISNULL(c.tipo_consulta, 'Medicina General') AS [Tipo de Consulta],
                    ISNULL(c.sintomas, 'Sin síntomas registrados') AS [Síntomas]
                FROM pacientes p
                LEFT JOIN (
                    SELECT id_cita, id_paciente, fecha_cita, tipo_consulta, sintomas,
                           ROW_NUMBER() OVER(PARTITION BY id_paciente ORDER BY fecha_cita DESC, id_cita DESC) as rn
                    FROM citas
                ) c ON p.id_paciente = c.id_paciente AND c.rn = 1
                ORDER BY p.id_paciente DESC;"

            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using adaptador As New SqlDataAdapter(consulta, conexion)
                        adaptador.Fill(tabla)
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("No se pudo cargar la lista de pacientes y citas: " & ex.Message, ex)
            End Try

            Return tabla
        End Function

        ''' <summary>
        ''' Busca registros de pacientes por código, nombre o cédula.
        ''' </summary>
        Public Function Buscar(criterio As String) As DataTable
            Dim tabla As New DataTable()
            Dim consulta As String = "
                SELECT 
                    p.id_paciente AS [ID],
                    p.codigo_paciente AS [Código],
                    p.nombre AS [Nombre del Paciente],
                    p.cedula AS [Cédula],
                    p.fecha_nacimiento AS [FechaNacimiento],
                    FORMAT(p.fecha_nacimiento, 'dd/MM/yyyy') AS [F. Nacimiento],
                    (DATEDIFF(YEAR, p.fecha_nacimiento, GETDATE()) - 
                        CASE WHEN (DATEADD(YEAR, DATEDIFF(YEAR, p.fecha_nacimiento, GETDATE()), p.fecha_nacimiento) > GETDATE()) 
                             THEN 1 ELSE 0 END) AS [Edad],
                    ISNULL(c.id_cita, 0) AS [IDCita],
                    ISNULL(c.fecha_cita, GETDATE()) AS [FechaCita],
                    FORMAT(c.fecha_cita, 'dd/MM/yyyy') AS [Fecha Cita],
                    ISNULL(c.tipo_consulta, 'Medicina General') AS [Tipo de Consulta],
                    ISNULL(c.sintomas, 'Sin síntomas registrados') AS [Síntomas]
                FROM pacientes p
                LEFT JOIN (
                    SELECT id_cita, id_paciente, fecha_cita, tipo_consulta, sintomas,
                           ROW_NUMBER() OVER(PARTITION BY id_paciente ORDER BY fecha_cita DESC, id_cita DESC) as rn
                    FROM citas
                ) c ON p.id_paciente = c.id_paciente AND c.rn = 1
                WHERE p.codigo_paciente LIKE @Criterio
                   OR p.nombre LIKE @Criterio
                   OR p.cedula LIKE @Criterio
                   OR CAST(p.id_paciente AS NVARCHAR) LIKE @Criterio
                ORDER BY p.id_paciente DESC;"

            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using comando As New SqlCommand(consulta, conexion)
                        comando.Parameters.Add(New SqlParameter("@Criterio", SqlDbType.VarChar, 100) With {.Value = "%" & criterio.Trim() & "%"})
                        Using adaptador As New SqlDataAdapter(comando)
                            adaptador.Fill(tabla)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al realizar la búsqueda: " & ex.Message, ex)
            End Try

            Return tabla
        End Function

        ''' <summary>
        ''' Obtiene un paciente específico y su cita activa por su identificador único.
        ''' </summary>
        Public Function ObtenerPorId(idPaciente As Integer) As Paciente
            Dim pac As Paciente = Nothing
            Dim consulta As String = "
                SELECT 
                    p.id_paciente, p.codigo_paciente, p.nombre, p.cedula, p.fecha_nacimiento,
                    ISNULL(c.id_cita, 0) AS id_cita,
                    ISNULL(c.fecha_cita, GETDATE()) AS fecha_cita,
                    ISNULL(c.tipo_consulta, 'Medicina General') AS tipo_consulta,
                    ISNULL(c.sintomas, '') AS sintomas
                FROM pacientes p
                LEFT JOIN (
                    SELECT id_cita, id_paciente, fecha_cita, tipo_consulta, sintomas,
                           ROW_NUMBER() OVER(PARTITION BY id_paciente ORDER BY fecha_cita DESC, id_cita DESC) as rn
                    FROM citas
                ) c ON p.id_paciente = c.id_paciente AND c.rn = 1
                WHERE p.id_paciente = @IdPaciente;"

            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using comando As New SqlCommand(consulta, conexion)
                        comando.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = idPaciente})

                        Using lector As SqlDataReader = comando.ExecuteReader()
                            If lector.Read() Then
                                pac = New Paciente() With {
                                    .IdPaciente = Convert.ToInt32(lector("id_paciente")),
                                    .CodigoPaciente = lector("codigo_paciente").ToString(),
                                    .Nombre = lector("nombre").ToString(),
                                    .Cedula = lector("cedula").ToString(),
                                    .FechaNacimiento = Convert.ToDateTime(lector("fecha_nacimiento")),
                                    .IdCita = Convert.ToInt32(lector("id_cita")),
                                    .FechaCita = Convert.ToDateTime(lector("fecha_cita")),
                                    .TipoConsulta = lector("tipo_consulta").ToString(),
                                    .Sintomas = lector("sintomas").ToString()
                                }
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al obtener la información del paciente: " & ex.Message, ex)
            End Try

            Return pac
        End Function

        ''' <summary>
        ''' Inserta un nuevo paciente y su cita médica en una sola transacción segura.
        ''' </summary>
        Public Function Insertar(paciente As Paciente) As Integer
            Dim nuevoIdPaciente As Integer = 0

            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using transaccion As SqlTransaction = conexion.BeginTransaction()
                        Try
                            ' 1. Insertar en tabla pacientes
                            Dim sqlPaciente As String = "
                                INSERT INTO pacientes (codigo_paciente, nombre, cedula, fecha_nacimiento)
                                VALUES (@Codigo, @Nombre, @Cedula, @FechaNac);
                                SELECT SCOPE_IDENTITY();"

                            Using cmdPaciente As New SqlCommand(sqlPaciente, conexion, transaccion)
                                cmdPaciente.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar, 10) With {.Value = paciente.CodigoPaciente})
                                cmdPaciente.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 100) With {.Value = paciente.Nombre})
                                cmdPaciente.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.VarChar, 20) With {.Value = paciente.Cedula})
                                cmdPaciente.Parameters.Add(New SqlParameter("@FechaNac", SqlDbType.Date) With {.Value = paciente.FechaNacimiento.Date})

                                nuevoIdPaciente = Convert.ToInt32(cmdPaciente.ExecuteScalar())
                            End Using

                            ' 2. Insertar en tabla citas
                            Dim sqlCita As String = "
                                INSERT INTO citas (id_paciente, fecha_cita, tipo_consulta, sintomas)
                                VALUES (@IdPaciente, @FechaCita, @TipoConsulta, @Sintomas);"

                            Using cmdCita As New SqlCommand(sqlCita, conexion, transaccion)
                                cmdCita.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = nuevoIdPaciente})
                                cmdCita.Parameters.Add(New SqlParameter("@FechaCita", SqlDbType.Date) With {.Value = paciente.FechaCita.Date})
                                cmdCita.Parameters.Add(New SqlParameter("@TipoConsulta", SqlDbType.VarChar, 100) With {.Value = paciente.TipoConsulta})
                                cmdCita.Parameters.Add(New SqlParameter("@Sintomas", SqlDbType.VarChar, 500) With {.Value = paciente.Sintomas})

                                cmdCita.ExecuteNonQuery()
                            End Using

                            transaccion.Commit()

                        Catch ex As Exception
                            transaccion.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
            Catch ex As SqlException
                If ex.Number = 2627 OrElse ex.Number = 2601 Then
                    Throw New Exception($"El código de paciente '{paciente.CodigoPaciente}' ya está registrado. Por favor ingrese un código diferente.", ex)
                End If
                Throw New Exception("Error de SQL al guardar el paciente: " & ex.Message, ex)
            Catch ex As Exception
                Throw New Exception("No se pudo guardar el paciente: " & ex.Message, ex)
            End Try

            Return nuevoIdPaciente
        End Function

        ''' <summary>
        ''' Actualiza los datos del paciente y de su cita correspondiente.
        ''' </summary>
        Public Function Actualizar(paciente As Paciente) As Boolean
            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using transaccion As SqlTransaction = conexion.BeginTransaction()
                        Try
                            ' 1. Actualizar tabla pacientes
                            Dim sqlPaciente As String = "
                                UPDATE pacientes 
                                SET codigo_paciente = @Codigo,
                                    nombre = @Nombre,
                                    cedula = @Cedula,
                                    fecha_nacimiento = @FechaNac
                                WHERE id_paciente = @IdPaciente;"

                            Using cmdPaciente As New SqlCommand(sqlPaciente, conexion, transaccion)
                                cmdPaciente.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar, 10) With {.Value = paciente.CodigoPaciente})
                                cmdPaciente.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 100) With {.Value = paciente.Nombre})
                                cmdPaciente.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.VarChar, 20) With {.Value = paciente.Cedula})
                                cmdPaciente.Parameters.Add(New SqlParameter("@FechaNac", SqlDbType.Date) With {.Value = paciente.FechaNacimiento.Date})
                                cmdPaciente.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = paciente.IdPaciente})

                                cmdPaciente.ExecuteNonQuery()
                            End Using

                            ' 2. Actualizar o insertar cita
                            If paciente.IdCita > 0 Then
                                Dim sqlCita As String = "
                                    UPDATE citas
                                    SET fecha_cita = @FechaCita,
                                        tipo_consulta = @TipoConsulta,
                                        sintomas = @Sintomas
                                    WHERE id_cita = @IdCita;"

                                Using cmdCita As New SqlCommand(sqlCita, conexion, transaccion)
                                    cmdCita.Parameters.Add(New SqlParameter("@FechaCita", SqlDbType.Date) With {.Value = paciente.FechaCita.Date})
                                    cmdCita.Parameters.Add(New SqlParameter("@TipoConsulta", SqlDbType.VarChar, 100) With {.Value = paciente.TipoConsulta})
                                    cmdCita.Parameters.Add(New SqlParameter("@Sintomas", SqlDbType.VarChar, 500) With {.Value = paciente.Sintomas})
                                    cmdCita.Parameters.Add(New SqlParameter("@IdCita", SqlDbType.Int) With {.Value = paciente.IdCita})

                                    cmdCita.ExecuteNonQuery()
                                End Using
                            Else
                                Dim sqlNuevaCita As String = "
                                    INSERT INTO citas (id_paciente, fecha_cita, tipo_consulta, sintomas)
                                    VALUES (@IdPaciente, @FechaCita, @TipoConsulta, @Sintomas);"

                                Using cmdNuevaCita As New SqlCommand(sqlNuevaCita, conexion, transaccion)
                                    cmdNuevaCita.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = paciente.IdPaciente})
                                    cmdNuevaCita.Parameters.Add(New SqlParameter("@FechaCita", SqlDbType.Date) With {.Value = paciente.FechaCita.Date})
                                    cmdNuevaCita.Parameters.Add(New SqlParameter("@TipoConsulta", SqlDbType.VarChar, 100) With {.Value = paciente.TipoConsulta})
                                    cmdNuevaCita.Parameters.Add(New SqlParameter("@Sintomas", SqlDbType.VarChar, 500) With {.Value = paciente.Sintomas})

                                    cmdNuevaCita.ExecuteNonQuery()
                                End Using
                            End If

                            transaccion.Commit()
                            Return True

                        Catch ex As Exception
                            transaccion.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
            Catch ex As SqlException
                If ex.Number = 2627 OrElse ex.Number = 2601 Then
                    Throw New Exception($"El código de paciente '{paciente.CodigoPaciente}' ya pertenece a otro registro.", ex)
                End If
                Throw New Exception("Error al actualizar paciente: " & ex.Message, ex)
            Catch ex As Exception
                Throw New Exception("No se pudo completar la actualización: " & ex.Message, ex)
            End Try
        End Function

        ''' <summary>
        ''' Elimina el paciente y sus citas asociadas.
        ''' </summary>
        Public Function Eliminar(idPaciente As Integer) As Boolean
            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using transaccion As SqlTransaction = conexion.BeginTransaction()
                        Try
                            ' Eliminar citas primero (por si la BD no tiene ON DELETE CASCADE configurado)
                            Dim sqlCitas As String = "DELETE FROM citas WHERE id_paciente = @IdPaciente;"
                            Using cmdCitas As New SqlCommand(sqlCitas, conexion, transaccion)
                                cmdCitas.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = idPaciente})
                                cmdCitas.ExecuteNonQuery()
                            End Using

                            ' Eliminar paciente
                            Dim sqlPaciente As String = "DELETE FROM pacientes WHERE id_paciente = @IdPaciente;"
                            Dim filas As Integer
                            Using cmdPaciente As New SqlCommand(sqlPaciente, conexion, transaccion)
                                cmdPaciente.Parameters.Add(New SqlParameter("@IdPaciente", SqlDbType.Int) With {.Value = idPaciente})
                                filas = cmdPaciente.ExecuteNonQuery()
                            End Using

                            transaccion.Commit()
                            Return filas > 0

                        Catch ex As Exception
                            transaccion.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Error al eliminar paciente: " & ex.Message, ex)
            End Try
        End Function

        ''' <summary>
        ''' Genera una sugerencia de código de paciente consecutivo (ej. PAC005).
        ''' </summary>
        Public Function GenerarSiguienteCodigo() As String
            Dim siguiente As String = "PAC001"
            Dim consulta As String = "SELECT ISNULL(MAX(id_paciente), 0) + 1 FROM pacientes;"

            Try
                Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                    Using comando As New SqlCommand(consulta, conexion)
                        Dim proxId = Convert.ToInt32(comando.ExecuteScalar())
                        siguiente = $"PAC{proxId.ToString("D3")}"
                    End Using
                End Using
            Catch ex As Exception
                ' Si hay problema generando sugerencia, retornar formato estándar
            End Try

            Return siguiente
        End Function

    End Class
End Namespace
