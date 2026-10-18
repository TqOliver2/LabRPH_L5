Imports System.Data
Imports RPH.Data
Imports RPH.Models
Imports RPH.UI

Namespace Forms
    ''' <summary>
    ''' Formulario principal del sistema 'Registro de Pacientes en un Hospital'.
    ''' Gestiona pacientes y sus citas médicas en la base de datos Hospital.
    ''' </summary>
    Public Class FrmPacientes

        Private ReadOnly DAL As New PacienteDAL()
        Private cargandoFila As Boolean = False
        Private idCitaActual As Integer = 0

        Private Sub FrmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                ' 1. Cargar recursos visuales (Logo reservado e ilustraciones médicas)
                picLogo.Image = RecursosVisuales.ObtenerImagenLogo(picLogo.Width, picLogo.Height)
                picAreaMedica.Image = RecursosVisuales.ObtenerIlustracionMedica(picAreaMedica.Width, picAreaMedica.Height)
                picHeaderMed.Image = RecursosVisuales.ObtenerIlustracionMedica(picHeaderMed.Width, picHeaderMed.Height)

                ' 2. Cargar opciones del ComboBox de consulta
                cboTipoConsulta.Items.Clear()
                cboTipoConsulta.Items.AddRange(New Object() {
                    "Medicina General",
                    "Pediatría",
                    "Cardiología",
                    "Urgencias",
                    "Traumatología",
                    "Ginecología",
                    "Odontología",
                    "Dermatología"
                })
                cboTipoConsulta.SelectedIndex = 0

                ' 3. Asegurar estructura de base de datos en SQL Server Hospital
                ConexionBD.AsegurarEstructuraBaseDeDatos()

                ' 4. Cargar lista y preparar formulario
                CargarPacientes()
                LimpiarFormulario()

            Catch ex As Exception
                MessageBox.Show("No se pudo iniciar la conexión con el servidor SQL Server Hospital: " & vbCrLf & ex.Message,
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Carga todos los pacientes y citas en el DataGridView.
        ''' </summary>
        Private Sub CargarPacientes()
            Try
                Cursor = Cursors.WaitCursor
                Dim dt As DataTable = DAL.ObtenerTodos()
                dgvPacientes.DataSource = dt
                ConfigurarColumnasGrid()
                lblEstado.Text = $"Total de pacientes registrados: {dt.Rows.Count} | Base de datos: Hospital"

            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al consultar los pacientes: " & vbCrLf & ex.Message,
                                "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor = Cursors.Default
            End Try
        End Sub

        ''' <summary>
        ''' Formatea y dimensiona las columnas del DataGridView de forma legible.
        ''' </summary>
        Private Sub ConfigurarColumnasGrid()
            If dgvPacientes.Columns.Count = 0 Then Return

            ' Ocultar columnas técnicas
            If dgvPacientes.Columns.Contains("FechaNacimiento") Then dgvPacientes.Columns("FechaNacimiento").Visible = False
            If dgvPacientes.Columns.Contains("IDCita") Then dgvPacientes.Columns("IDCita").Visible = False
            If dgvPacientes.Columns.Contains("FechaCita") Then dgvPacientes.Columns("FechaCita").Visible = False

            ' Ajustar anchos y alineación
            If dgvPacientes.Columns.Contains("ID") Then
                dgvPacientes.Columns("ID").Width = 45
                dgvPacientes.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvPacientes.Columns.Contains("Código") Then
                dgvPacientes.Columns("Código").Width = 75
                dgvPacientes.Columns("Código").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvPacientes.Columns.Contains("Nombre del Paciente") Then
                dgvPacientes.Columns("Nombre del Paciente").Width = 150
            End If

            If dgvPacientes.Columns.Contains("Cédula") Then
                dgvPacientes.Columns("Cédula").Width = 90
            End If

            If dgvPacientes.Columns.Contains("F. Nacimiento") Then
                dgvPacientes.Columns("F. Nacimiento").Width = 85
                dgvPacientes.Columns("F. Nacimiento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvPacientes.Columns.Contains("Edad") Then
                dgvPacientes.Columns("Edad").Width = 45
                dgvPacientes.Columns("Edad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvPacientes.Columns.Contains("Fecha Cita") Then
                dgvPacientes.Columns("Fecha Cita").Width = 85
                dgvPacientes.Columns("Fecha Cita").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If dgvPacientes.Columns.Contains("Tipo de Consulta") Then
                dgvPacientes.Columns("Tipo de Consulta").Width = 110
            End If

            If dgvPacientes.Columns.Contains("Síntomas") Then
                dgvPacientes.Columns("Síntomas").Width = 180
            End If
        End Sub

        ''' <summary>
        ''' Restaura los controles a su estado inicial para ingresar un nuevo registro.
        ''' </summary>
        Private Sub LimpiarFormulario()
            txtId.Text = "(Nuevo)"
            idCitaActual = 0
            txtCodigo.Text = DAL.GenerarSiguienteCodigo()
            txtNombre.Clear()
            txtCedula.Clear()
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-25)
            ActualizarEtiquetaEdad()
            dtpFechaCita.Value = DateTime.Today
            cboTipoConsulta.SelectedIndex = 0
            txtSintomas.Clear()

            cargandoFila = True
            dgvPacientes.ClearSelection()
            cargandoFila = False

            txtNombre.Focus()
        End Sub

        Private Function CalcularEdad(fechaNac As DateTime) As Integer
            Dim hoy As DateTime = DateTime.Today
            Dim edad As Integer = hoy.Year - fechaNac.Year
            If fechaNac.Date > hoy.AddYears(-edad) Then
                edad -= 1
            End If
            Return Math.Max(0, edad)
        End Function

        Private Sub ActualizarEtiquetaEdad()
            Dim edad = CalcularEdad(dtpFechaNacimiento.Value)
            lblEdadValor.Text = $"{edad} años"
        End Sub

        Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged
            ActualizarEtiquetaEdad()
        End Sub

        ''' <summary>
        ''' Valida que todos los campos obligatorios del paciente y cita cumplan las restricciones.
        ''' </summary>
        Private Function ValidarDatos() As Boolean
            ' 1. Código de paciente
            If String.IsNullOrWhiteSpace(txtCodigo.Text) Then
                MessageBox.Show("Por favor, ingrese el código del paciente (ej. PAC001).",
                                "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCodigo.Focus()
                Return False
            End If

            ' 2. Cédula
            If String.IsNullOrWhiteSpace(txtCedula.Text) Then
                MessageBox.Show("Por favor, ingrese la cédula del paciente.",
                                "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCedula.Focus()
                Return False
            End If

            ' 3. Nombre
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then
                MessageBox.Show("Por favor, ingrese el nombre completo del paciente.",
                                "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNombre.Focus()
                Return False
            End If

            ' 4. Fecha de nacimiento no futura
            If dtpFechaNacimiento.Value.Date > DateTime.Today Then
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.",
                                "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpFechaNacimiento.Focus()
                Return False
            End If

            ' 5. Tipo de consulta
            If cboTipoConsulta.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione el tipo de consulta médica.",
                                "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboTipoConsulta.Focus()
                Return False
            End If

            ' 6. Síntomas ingresados en el cuadro de texto
            If String.IsNullOrWhiteSpace(txtSintomas.Text) Then
                MessageBox.Show("Por favor, describa los síntomas manifestados o motivo de consulta en el cuadro de texto.",
                                "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSintomas.Focus()
                Return False
            End If

            Return True
        End Function

        ''' <summary>
        ''' Construye un objeto Paciente con los datos del formulario.
        ''' </summary>
        Private Function ConstruirObjetoPaciente() As Paciente
            Dim pac As New Paciente() With {
                .CodigoPaciente = txtCodigo.Text.Trim().ToUpper(),
                .Nombre = txtNombre.Text.Trim(),
                .Cedula = txtCedula.Text.Trim(),
                .FechaNacimiento = dtpFechaNacimiento.Value.Date,
                .IdCita = idCitaActual,
                .FechaCita = dtpFechaCita.Value.Date,
                .TipoConsulta = cboTipoConsulta.SelectedItem.ToString(),
                .Sintomas = txtSintomas.Text.Trim()
            }

            Dim id As Integer
            If Integer.TryParse(txtId.Text.Trim(), id) Then
                pac.IdPaciente = id
            End If

            Return pac
        End Function

        ''' <summary>
        ''' Guarda un nuevo paciente y su cita médica en la base de datos Hospital.
        ''' </summary>
        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            If Not ValidarDatos() Then Return

            Dim idExistente As Integer
            If Integer.TryParse(txtId.Text.Trim(), idExistente) Then
                Dim resp = MessageBox.Show($"Tiene seleccionado el paciente #{idExistente} ({txtCodigo.Text}).{vbCrLf}{vbCrLf}¿Desea registrar esta información como un NUEVO paciente?{vbCrLf}(Si deseaba modificar el paciente actual, presione 'No' y luego 'Actualizar')",
                                           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp <> DialogResult.Yes Then Return
            End If

            Try
                Dim nuevoPaciente As Paciente = ConstruirObjetoPaciente()
                Dim idGenerado As Integer = DAL.Insertar(nuevoPaciente)

                If idGenerado > 0 Then
                    MessageBox.Show($"¡Paciente registrado con éxito en la base de datos Hospital!{vbCrLf}" &
                                    $"• ID asignado: #{idGenerado}{vbCrLf}" &
                                    $"• Código: {nuevoPaciente.CodigoPaciente}{vbCrLf}" &
                                    $"• Cita agendada para: {nuevoPaciente.FechaCita:dd/MM/yyyy}",
                                    "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarFormulario()
                    CargarPacientes()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Actualiza el paciente y su cita médica.
        ''' </summary>
        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Dim idActualizar As Integer
            If Not Integer.TryParse(txtId.Text.Trim(), idActualizar) OrElse idActualizar <= 0 Then
                MessageBox.Show("Por favor, seleccione un paciente de la lista para actualizar sus datos.",
                                "Paciente No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not ValidarDatos() Then Return

            Try
                Dim pacienteActualizado As Paciente = ConstruirObjetoPaciente()
                pacienteActualizado.IdPaciente = idActualizar
                pacienteActualizado.IdCita = idCitaActual

                Dim exito As Boolean = DAL.Actualizar(pacienteActualizado)

                If exito Then
                    MessageBox.Show($"Los datos del paciente #{idActualizar} ({pacienteActualizado.CodigoPaciente}) y su cita fueron actualizados correctamente.",
                                    "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarFormulario()
                    CargarPacientes()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Elimina el paciente y su cita solicitando confirmación de seguridad.
        ''' </summary>
        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            Dim idEliminar As Integer
            If Not Integer.TryParse(txtId.Text.Trim(), idEliminar) OrElse idEliminar <= 0 Then
                MessageBox.Show("Por favor, seleccione de la lista el paciente que desea eliminar.",
                                "Paciente No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nombre As String = txtNombre.Text.Trim()
            Dim codigo As String = txtCodigo.Text.Trim()
            Dim mensaje As String = $"¿Está seguro de que desea eliminar permanentemente al siguiente paciente?{vbCrLf}{vbCrLf}" &
                                    $"• ID: #{idEliminar}{vbCrLf}" &
                                    $"• Código: {codigo}{vbCrLf}" &
                                    $"• Nombre: {nombre}{vbCrLf}{vbCrLf}" &
                                    "Se eliminará también su historial de citas médicas."

            Dim confirmacion = MessageBox.Show(mensaje, "Confirmar Eliminación",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If confirmacion = DialogResult.Yes Then
                Try
                    Dim eliminado As Boolean = DAL.Eliminar(idEliminar)
                    If eliminado Then
                        MessageBox.Show($"El registro del paciente #{idEliminar} ha sido eliminado satisfactoriamente.",
                                        "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarFormulario()
                        CargarPacientes()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Busca registros de pacientes por código, nombre o cédula.
        ''' </summary>
        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            Dim criterio As String = txtBuscar.Text.Trim()

            If String.IsNullOrWhiteSpace(criterio) Then
                MessageBox.Show("Por favor, ingrese un código, nombre o cédula para realizar la búsqueda.",
                                "Criterio Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBuscar.Focus()
                Return
            End If

            Try
                Cursor = Cursors.WaitCursor
                Dim dt As DataTable = DAL.Buscar(criterio)
                dgvPacientes.DataSource = dt
                ConfigurarColumnasGrid()

                If dt.Rows.Count = 0 Then
                    MessageBox.Show($"No se encontraron pacientes que coincidan con '{criterio}'.",
                                    "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblEstado.Text = $"Sin resultados para: '{criterio}' | Haga clic en 'Mostrar Todo' para recargar"
                Else
                    lblEstado.Text = $"Búsqueda: {dt.Rows.Count} registro(s) encontrado(s) para '{criterio}'"
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor = Cursors.Default
            End Try
        End Sub

        Private Sub btnMostrarTodo_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
            txtBuscar.Clear()
            CargarPacientes()
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarFormulario()
        End Sub

        ''' <summary>
        ''' Abre el formulario FrmDetallePaciente con la ficha completa del paciente seleccionado.
        ''' </summary>
        Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click
            Dim idSeleccionado As Integer
            If Not Integer.TryParse(txtId.Text.Trim(), idSeleccionado) OrElse idSeleccionado <= 0 Then
                MessageBox.Show("Por favor, seleccione un paciente de la lista para visualizar su ficha detallada.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Try
                Dim paciente As Paciente = DAL.ObtenerPorId(idSeleccionado)
                If paciente IsNot Nothing Then
                    Using frmDetalle As New FrmDetallePaciente(paciente)
                        frmDetalle.ShowDialog(Me)
                    End Using
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al Mostrar Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Dim respuesta = MessageBox.Show("¿Está seguro de que desea salir del sistema de Registro de Pacientes?",
                                            "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                Me.Close()
            End If
        End Sub

        Private Sub dgvPacientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPacientes.SelectionChanged
            If cargandoFila Then Return
            CargarDatosFilaSeleccionada()
        End Sub

        Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
            If e.RowIndex >= 0 Then
                CargarDatosFilaSeleccionada()
            End If
        End Sub

        ''' <summary>
        ''' Carga los datos de la fila seleccionada del DataGridView en los controles.
        ''' </summary>
        Private Sub CargarDatosFilaSeleccionada()
            If dgvPacientes.CurrentRow Is Nothing OrElse dgvPacientes.CurrentRow.Index < 0 Then Return

            Try
                Dim fila As DataGridViewRow = dgvPacientes.CurrentRow

                If fila.Cells("ID").Value IsNot Nothing Then
                    txtId.Text = fila.Cells("ID").Value.ToString()
                End If

                If fila.Cells("Código").Value IsNot Nothing Then
                    txtCodigo.Text = fila.Cells("Código").Value.ToString()
                End If

                If fila.Cells("Nombre del Paciente").Value IsNot Nothing Then
                    txtNombre.Text = fila.Cells("Nombre del Paciente").Value.ToString()
                End If

                If fila.Cells("Cédula").Value IsNot Nothing Then
                    txtCedula.Text = fila.Cells("Cédula").Value.ToString()
                End If

                If fila.Cells("FechaNacimiento").Value IsNot Nothing AndAlso Not DBNull.Value.Equals(fila.Cells("FechaNacimiento").Value) Then
                    dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells("FechaNacimiento").Value)
                    ActualizarEtiquetaEdad()
                End If

                If fila.Cells("IDCita").Value IsNot Nothing AndAlso Not DBNull.Value.Equals(fila.Cells("IDCita").Value) Then
                    idCitaActual = Convert.ToInt32(fila.Cells("IDCita").Value)
                Else
                    idCitaActual = 0
                End If

                If fila.Cells("FechaCita").Value IsNot Nothing AndAlso Not DBNull.Value.Equals(fila.Cells("FechaCita").Value) Then
                    dtpFechaCita.Value = Convert.ToDateTime(fila.Cells("FechaCita").Value)
                End If

                If fila.Cells("Tipo de Consulta").Value IsNot Nothing Then
                    cboTipoConsulta.SelectedItem = fila.Cells("Tipo de Consulta").Value.ToString()
                End If

                If fila.Cells("Síntomas").Value IsNot Nothing Then
                    txtSintomas.Text = fila.Cells("Síntomas").Value.ToString()
                End If

            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error al cargar fila: " & ex.Message)
            End Try
        End Sub

        Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                btnBuscar.PerformClick()
            End If
        End Sub

    End Class
End Namespace
