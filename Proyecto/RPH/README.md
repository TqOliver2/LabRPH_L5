# Registro de Pacientes en un Hospital (RPH)

**Asignatura:** Desarrollo de Software VIII  
**Docente:** Prof. Jorge Marín  
**Tecnología:** Visual Basic .NET (Windows Forms) / .NET 9.0  
**Base de Datos:** SQL Server (`Hospital`)  
**Tablas:** `pacientes` y `citas`

---

## 1. Descripción del Sistema

**"Registro de Pacientes en un Hospital"** es una aplicación de escritorio orientada a la administración de admisiones y citas médicas en una institución de salud. Permite registrar nuevos pacientes junto con su cita clínica, consultar el historial de pacientes, buscar registros de forma ágil (por código, nombre o cédula), modificar datos existentes, revisar la ficha técnica detallada en una segunda ventana y eliminar registros con confirmación de seguridad.

La aplicación implementa una arquitectura modular en capas:
* **Módulo de Conexión (Conexión Central):** [`Conexion.vb`](./Conexion.vb).
* **Presentación (Forms):** `FrmPacientes` y `FrmDetallePaciente`.
* **Lógica / Entidades (Models):** `Paciente.vb`.
* **Acceso a Datos (Data):** `PacienteDAL.vb` y `ConexionBD.vb`.
* **Identidad Visual (UI):** `ColoresTema.vb` y `RecursosVisuales.vb`.

---

## 2. Paleta de Colores Oficial

El diseño visual respeta estrictamente la paleta de colores requerida:

| Elemento | Color Hexadecimal | Color RGB | Uso Principal |
| :--- | :---: | :---: | :--- |
| **Morado Oscuro** | `#413074` | `RGB(65, 48, 116)` | Encabezados, títulos de módulo, botones secundarios y cabeceras de DataGridView. |
| **Morado Claro** | `#736FA1` | `RGB(115, 111, 161)` | Subtítulos, bordes de controles, etiquetas descriptivas y botones auxiliares. |
| **Turquesa** | `#0FB7B8` | `RGB(15, 183, 184)` | Botones de acciones principales (Guardar, Buscar, Ver Detalle) y resaltado de selección. |
| **Fondo Claro** | `#F7F8FA` | `RGB(247, 248, 250)` | Áreas de trabajo, fondo principal de formularios y filas alternadas. |

---

## 3. Estructura de la Base de Datos (`Hospital`)

El script oficial de creación se encuentra en el archivo [`Hospital_Script.sql`](./Hospital_Script.sql).

### Tabla: `pacientes`
```sql
CREATE TABLE pacientes (
    id_paciente INT IDENTITY(1,1) PRIMARY KEY,
    codigo_paciente VARCHAR(10) NOT NULL UNIQUE,
    nombre VARCHAR(100) NOT NULL,
    cedula VARCHAR(20) NOT NULL,
    fecha_nacimiento DATE
);
```

### Tabla: `citas`
```sql
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
```

> **Nota:** La aplicación incluye un mecanismo en `ConexionBD.AsegurarEstructuraBaseDeDatos()` que verifica y crea las tablas si aún no existen, garantizando que el docente pueda ejecutar la aplicación sin errores de configuración.

---

## 4. Formularios y Funcionalidades

### Formulario Principal (`FrmPacientes`)
1. **Espacio para Logo:** Cuadro claramente reservado en la cabecera con el texto discreto `[ Espacio para Logo ]`.
2. **Datos del Paciente:**
   * `txtId`: ID interno del sistema (solo lectura).
   * `txtCodigo`: Código único de paciente (ej. `PAC001`, con sugerencia automática).
   * `txtCedula`: Cédula de identidad personal.
   * `txtNombre`: Nombre completo del paciente.
   * `dtpFechaNacimiento`: Selector de fecha de nacimiento.
   * `lblEdadValor`: Muestra la edad calculada automáticamente a partir de la fecha de nacimiento.
3. **Datos de la Cita Médica:**
   * `dtpFechaCita`: Selector de fecha programada para la cita.
   * `cboTipoConsulta`: Menú desplegable con especialidades médicas (Medicina General, Urgencias, Cardiología, Pediatría, Traumatología, etc.).
   * `txtSintomas`: **Cuadro de texto multilínea (TextBox)** donde se escriben detalladamente los síntomas manifestados o motivo de consulta (hasta 500 caracteres), reemplazando las opciones predefinidas por casillas de verificación.
4. **Operaciones:**
   * `btnGuardar`: Valida todos los campos e inserta en `pacientes` y `citas` mediante una transacción SQL segura.
   * `btnActualizar`: Modifica los datos del paciente y su cita seleccionada.
   * `btnEliminar`: Solicita confirmación mediante un cuadro de diálogo antes de eliminar el registro.
   * `btnLimpiar`: Restablece todos los controles y coloca el foco en `txtNombre`.
   * `btnVerDetalle`: Abre la ventana modal `FrmDetallePaciente`.
   * `btnProbarConexion`: Prueba en tiempo real la apertura y cierre de la conexión con SQL Server (`Conexion.ObtenerConexion()`).
   * `btnSalir`: Cierra la aplicación de manera ordenada.
5. **Búsqueda y DataGridView:**
   * `txtBuscar`, `btnBuscar` y `btnMostrarTodo`: Búsqueda instantánea por código, nombre o cédula.
   * `dgvPacientes`: Grilla con formato hospitalario que al hacer clic carga automáticamente los datos en los controles para facilitar su edición.

### Segunda Interfaz (`FrmDetallePaciente`)
* Ventana modal diseñada con la misma identidad visual y paleta de colores.
* Contiene un `PictureBox` con una ilustración médica institucional.
* Muestra el expediente completo: ID y Código, Nombre, Cédula, Fecha de Nacimiento y Edad, Fecha de Cita, Tipo de Consulta y el texto completo de los Síntomas Reportados.
* Botón para regresar/cerrar.

---

## 5. Instrucciones de Ejecución

### Desde Visual Studio
1. Abrir la solución `RPH.sln`.
2. Verificar que SQL Server esté iniciado.
3. Presionar **F5** o el botón **Iniciar**.

### Desde la Terminal
```powershell
dotnet run
```
