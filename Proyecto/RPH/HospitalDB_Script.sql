-- ====================================================================
-- Script de Creación de Base de Datos y Tabla
-- Proyecto: Registro de Pacientes en un Hospital (RPH)
-- Asignatura: Desarrollo de Software VIII
-- Estudiante / Desarrollador: Oliver González
-- Docente: Prof. Jorge Marín
-- ====================================================================

USE master;
GO

-- 1. Crear Base de Datos si no existe
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HospitalDB')
BEGIN
    CREATE DATABASE HospitalDB;
    PRINT 'Base de datos HospitalDB creada correctamente.';
END
ELSE
BEGIN
    PRINT 'La base de datos HospitalDB ya existe.';
END
GO

USE HospitalDB;
GO

-- 2. Crear Tabla Pacientes si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pacientes')
BEGIN
    CREATE TABLE Pacientes (
        IdPaciente INT IDENTITY(1001, 1) PRIMARY KEY,
        NombreCompleto NVARCHAR(150) NOT NULL,
        Edad INT NOT NULL,
        Genero NVARCHAR(20) NOT NULL,
        TipoConsulta NVARCHAR(50) NOT NULL,
        Fiebre BIT NOT NULL DEFAULT 0,
        Dolor BIT NOT NULL DEFAULT 0,
        Tos BIT NOT NULL DEFAULT 0,
        DolorCabeza BIT NOT NULL DEFAULT 0,
        Sintomas NVARCHAR(250) NOT NULL,
        FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
    );
    PRINT 'Tabla Pacientes creada correctamente.';

    -- 3. Inserción de datos iniciales para pruebas
    INSERT INTO Pacientes (NombreCompleto, Edad, Genero, TipoConsulta, Fiebre, Dolor, Tos, DolorCabeza, Sintomas)
    VALUES 
    (N'Carlos Mendoza Soto', 34, N'Masculino', N'Medicina General', 1, 0, 1, 1, N'Fiebre, Tos, Dolor de cabeza'),
    (N'Valeria Gómez Rivas', 27, N'Femenino', N'Urgencias', 0, 1, 0, 1, N'Dolor, Dolor de cabeza'),
    (N'Elena Morales Ortiz', 62, N'Femenino', N'Cardiología', 0, 1, 0, 0, N'Dolor'),
    (N'Andrés Castillo Vega', 45, N'Masculino', N'Traumatología', 0, 1, 0, 0, N'Dolor'),
    (N'Sofía Navarro Peña', 8, N'Femenino', N'Pediatría', 1, 0, 1, 0, N'Fiebre, Tos');

    PRINT 'Datos de prueba insertados con éxito.';
END
ELSE
BEGIN
    PRINT 'La tabla Pacientes ya existe.';
END
GO

-- 4. Comprobación de registros
SELECT 
    IdPaciente AS [N° Registro],
    NombreCompleto AS [Nombre del Paciente],
    Edad,
    Genero AS [Género],
    TipoConsulta AS [Tipo de Consulta],
    Sintomas AS [Síntomas Registrados],
    FORMAT(FechaRegistro, 'dd/MM/yyyy HH:mm') AS [Fecha de Registro]
FROM Pacientes;
GO
