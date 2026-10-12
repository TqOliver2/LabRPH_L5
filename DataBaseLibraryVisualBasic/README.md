# DatabaseLibrary

Biblioteca de acceso a datos para .NET (.NET 9.0) orientada a la gestión y consulta de pacientes y citas médicas en bases de datos relacionales Microsoft SQL Server.

El proyecto se distribuye como código fuente y ensamblado binario (`.dll`), permitiendo su integración directa en aplicaciones de escritorio, consola o web basadas en .NET.

---

## Estructura del Código

- **`Database.Modelos`**: Entidades de dominio que representan las estructuras de datos del negocio.
- **`Database.Repositorios`**: Clases de acceso a datos que encapsulan la lógica de consulta y persistencia en base de datos.
- **`Database.Connection`**: Componente de bajo nivel para la creación de conexiones `SqlConnection`.

---

## Requisitos Previos

- **.NET 9.0 SDK** (para compilar desde código fuente) o **.NET 9.0 Runtime** (para ejecutar la `.dll`).
- **Microsoft SQL Server**.
- Paquete NuGet requerido en el proyecto consumidor:
  ```powershell
  dotnet add package Microsoft.Data.SqlClient
  ```

---

## Configuración de Conexión

Cada repositorio se instancia suministrando de forma explícita una cadena de conexión estándar a SQL Server:

```text
Server=HOST_O_IP;Database=NOMBRE_BD;User Id=USUARIO;Password=CONTRASEÑA;TrustServerCertificate=True;
```

---

## Repositorios y Guía de Uso (`Database.Repositorios`)

Cada repositorio maneja internamente la apertura y cierre de conexiones mediante bloques de liberación de recursos (`Using`), garantizando consultas seguras y parametrizadas.

### `PacientesRepositorio`

Maneja las operaciones de lectura y registro de pacientes.

```vb
' Instanciación del repositorio con la cadena de conexión
Dim pacienteRepo As New PacientesRepositorio(connectionString)
```

- **`GetPacientes() As DataTable`**  
  Obtiene el listado completo de pacientes registrados.
  ```vb
  Dim dtPacientes As DataTable = pacienteRepo.GetPacientes()
  ```

- **`GetByPacienteId(idPaciente As Integer) As DataTable`**  
  Busca un paciente específico mediante su identificador primario (`id_paciente`).
  ```vb
  Dim dtPaciente As DataTable = pacienteRepo.GetByPacienteId(1)
  ```

- **`GetByPacienteCod(codigoPaciente As String) As DataTable`**  
  Busca un paciente a través de su código clínico (`codigo_paciente`).
  ```vb
  Dim dtPaciente As DataTable = pacienteRepo.GetByPacienteCod("PAC-001")
  ```

- **`AddPaciente(p As Paciente) As Boolean`**  
  Registra un nuevo paciente utilizando una consulta parametrizada. Retorna `True` si la inserción fue exitosa.
  ```vb
  Dim nuevoPaciente As New Paciente(0, "PAC-101", "Nombre Apellido", "001-000000-0000X", New DateTime(1990, 1, 1))
  nuevoPaciente.Sexo = "M"
  Dim guardado As Boolean = pacienteRepo.AddPaciente(nuevoPaciente)
  ```

---

### `CitasRepositorio`

Maneja las operaciones de consulta y registro de citas médicas.

```vb
' Instanciación del repositorio con la cadena de conexión
Dim citasRepo As New CitasRepositorio(connectionString)
```

- **`GetCitas() As DataTable`**  
  Obtiene el histórico completo de citas médicas registradas.
  ```vb
  Dim dtCitas As DataTable = citasRepo.GetCitas()
  ```

- **`GetCitasByPacienteId(idPaciente As Integer) As DataTable`**  
  Obtiene todas las citas asociadas al identificador del paciente (`id_paciente`), ordenadas por fecha.
  ```vb
  Dim dtCitasPaciente As DataTable = citasRepo.GetCitasByPacienteId(1)
  ```

- **`GetCitasByPacienteCod(codigoPaciente As String) As DataTable`**  
  Obtiene las citas asociadas al código clínico del paciente.
  ```vb
  Dim dtCitasPaciente As DataTable = citasRepo.GetCitasByPacienteCod("PAC-001")
  ```

- **`AddCita(c As Cita) As Boolean`**  
  Registra una nueva cita médica vinculada a un paciente. Retorna `True` si la inserción fue exitosa.
  ```vb
  Dim nuevaCita As New Cita(0, 1, DateOnly.FromDateTime(DateTime.Today))
  nuevaCita.TipoConsulta = "Medicina General"
  nuevaCita.Sintomas = "Fiebre y dolor de cabeza"
  Dim registrada As Boolean = citasRepo.AddCita(nuevaCita)
  ```

---

