Namespace Models
    ''' <summary>
    ''' Representa la entidad Paciente y los datos de su cita clínica en el sistema hospitalario.
    ''' </summary>
    Public Class Paciente
        ' Campos de la tabla 'pacientes'
        Public Property IdPaciente As Integer
        Public Property CodigoPaciente As String
        Public Property Nombre As String
        Public Property Cedula As String
        Public Property FechaNacimiento As DateTime

        ' Campos de la tabla 'citas'
        Public Property IdCita As Integer
        Public Property FechaCita As DateTime
        Public Property TipoConsulta As String
        Public Property Sintomas As String

        Public Sub New()
            IdPaciente = 0
            CodigoPaciente = String.Empty
            Nombre = String.Empty
            Cedula = String.Empty
            FechaNacimiento = DateTime.Today.AddYears(-25)

            IdCita = 0
            FechaCita = DateTime.Today
            TipoConsulta = "Medicina General"
            Sintomas = String.Empty
        End Sub

        ''' <summary>
        ''' Calcula la edad en años a partir de la fecha de nacimiento.
        ''' </summary>
        Public ReadOnly Property Edad As Integer
            Get
                Dim hoy As DateTime = DateTime.Today
                Dim anos As Integer = hoy.Year - FechaNacimiento.Year
                If FechaNacimiento.Date > hoy.AddYears(-anos) Then
                    anos -= 1
                End If
                Return Math.Max(0, anos)
            End Get
        End Property
    End Class
End Namespace
