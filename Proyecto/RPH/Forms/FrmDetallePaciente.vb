Imports RPH.Models
Imports RPH.UI

Namespace Forms
    ''' <summary>
    ''' Formulario secundario para visualizar la ficha técnica completa del paciente y su cita médica.
    ''' </summary>
    Public Class FrmDetallePaciente
        Private Property PacienteActual As Paciente

        Public Sub New(paciente As Paciente)
            InitializeComponent()
            Me.PacienteActual = paciente
        End Sub

        Private Sub FrmDetallePaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Cargar la ilustración médica temática
            picDetalleMedico.Image = RecursosVisuales.ObtenerIlustracionMedica(picDetalleMedico.Width, picDetalleMedico.Height)

            ' Cargar datos completos del paciente y la cita en los controles
            If PacienteActual IsNot Nothing Then
                lblValorId.Text = $"#{PacienteActual.IdPaciente} - {PacienteActual.CodigoPaciente}"
                lblValorNombre.Text = PacienteActual.Nombre
                lblValorCedula.Text = PacienteActual.Cedula
                lblValorNacimiento.Text = $"{PacienteActual.FechaNacimiento:dd/MM/yyyy} ({PacienteActual.Edad} años)"
                lblValorFechaCita.Text = PacienteActual.FechaCita.ToString("dd/MM/yyyy")
                lblValorTipoConsulta.Text = PacienteActual.TipoConsulta
                txtValorSintomas.Text = If(String.IsNullOrWhiteSpace(PacienteActual.Sintomas), "Sin síntomas especificados", PacienteActual.Sintomas)
            End If
        End Sub

        Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Me.Close()
        End Sub
    End Class
End Namespace
