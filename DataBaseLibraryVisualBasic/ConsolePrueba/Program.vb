Imports System
Imports System.Data
Imports Database.Repositorios

Module Program
    Sub Main()
        Dim config As New AppConfig()

        Dim connectionString As String = config.GetConnectionString()


        Dim pacienteRep As New PacientesRepositorio(connectionString)
        Dim citasRep As New CitasRepositorio(connectionString)

        Dim pacientes As DataTable = pacienteRep.GetPacientes()
        Dim citas As DataTable = citasRep.GetCitas()
        Dim citasPaciente As DataTable = citasRep.GetCitasByPacienteId(3)


        Console.WriteLine("=== PACIENTES ===")
        Console.WriteLine()

        For Each row As DataRow In pacientes.Rows

            Console.WriteLine($"ID:                {row("id_paciente")}")
            Console.WriteLine($"Código:            {row("codigo_paciente")}")
            Console.WriteLine($"Nombre:            {row("nombre")}")
            Console.WriteLine($"Sexo:              {row("sexo")}")
            Console.WriteLine($"Cédula:            {row("cedula")}")
            Console.WriteLine($"Fecha nacimiento:  {row("fecha_nacimiento")}")

            Console.WriteLine("-------------------------------")

        Next

        Console.WriteLine()
        Console.WriteLine($"Total pacientes: {pacientes.Rows.Count}")



        Console.WriteLine("=== CITAS ===")
        Console.WriteLine()

        For Each row As DataRow In citas.Rows

            Console.WriteLine($"ID cita:           {row("id_cita")}")
            Console.WriteLine($"ID paciente:       {row("id_paciente")}")
            Console.WriteLine($"Fecha cita:        {row("fecha_cita")}")
            Console.WriteLine($"Tipo consulta:     {row("tipo_consulta")}")
            Console.WriteLine($"Síntomas:          {row("sintomas")}")

            Console.WriteLine("-------------------------------")

        Next

        Console.WriteLine()
        Console.WriteLine($"Total citas: {citas.Rows.Count}")


        Console.WriteLine()
        Console.WriteLine("=== CITAS DEL PACIENTE ===")
        Console.WriteLine()



        For Each row As DataRow In citasPaciente.Rows

            Console.WriteLine($"ID cita:           {row("id_cita")}")
            Console.WriteLine($"Fecha cita:        {row("fecha_cita")}")
            Console.WriteLine($"Tipo consulta:     {row("tipo_consulta")}")
            Console.WriteLine($"Síntomas:          {row("sintomas")}")

            Console.WriteLine("-------------------------------")

        Next

        Console.WriteLine($"Total citas: {citasPaciente.Rows.Count}")




    End Sub

End Module
