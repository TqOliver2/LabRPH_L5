Namespace Database.Modelos

    Public Class Paciente
        Public Property Id As Integer
        Public Property CodigoPaciente As String
        Public Property Nombre As String
        Public Property Cedula As String
        Public Property FechaNacimiento As DateTime?

        Public Property Sexo As String


        Public Sub New(
        id As Integer,
        codigoPaciente As String,
        nombre As String,
        cedula As String,
        sexo as String,
        fechaNacimiento As DateTime?)

            Me.Id = id
            Me.CodigoPaciente = codigoPaciente
            Me.Nombre = nombre
            Me.Cedula = cedula
            Me.FechaNacimiento = fechaNacimiento
            Me.Sexo = sexo


        End Sub

    End Class



    Public Class Cita

        Public Property IdCita As Integer
        Public Property IdPaciente As Integer
        Public Property FechaCita As DateOnly
        Public Property TipoConsulta As String

        Public Property Sintomas As String

        Public Sub New(
            idCita As Integer,
            idPaciente As Integer,
            fechaCita As DateOnly,
            tipoConsulta as String,
            sintomas as String)

            Me.IdCita = idCita
            Me.IdPaciente = idPaciente
            Me.FechaCita = fechaCita

            Me.TipoConsulta = tipoConsulta
            Me.Sintomas = sintomas

        End Sub

    End Class

End Namespace
