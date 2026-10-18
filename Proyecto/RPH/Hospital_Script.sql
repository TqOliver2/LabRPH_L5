-- ====================================================================
-- Script de Creación de Base de Datos y Tablas
-- Proyecto: Registro de Pacientes en un Hospital (RPH)
-- Asignatura: Desarrollo de Software VIII
-- Base de Datos: Hospital
-- ====================================================================

USE master;
GO

-- 1. Crear base de datos
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Hospital')
BEGIN
    CREATE DATABASE Hospital;
    PRINT 'Base de datos Hospital creada correctamente.';
END
GO

-- 2. Seleccionar la base de datos
USE Hospital;
GO

-- 3. Crear esquema Hospital
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'Hospital')
BEGIN
    EXEC('CREATE SCHEMA Hospital;');
    PRINT 'Esquema Hospital creado correctamente.';
END
GO

-- 4. Tabla de Pacientes
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'pacientes')
BEGIN
    CREATE TABLE pacientes (
        id_paciente INT IDENTITY(1,1) PRIMARY KEY,
        codigo_paciente VARCHAR(10) NOT NULL UNIQUE,
        nombre VARCHAR(100) NOT NULL,
        cedula VARCHAR(20) NOT NULL,
        fecha_nacimiento DATE
    );
    PRINT 'Tabla pacientes creada correctamente.';
END
GO

-- 5. Tabla de Citas
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'citas')
BEGIN
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
    PRINT 'Tabla citas creada correctamente.';
END
GO

-- 6. Insertar datos de prueba iniciales
IF NOT EXISTS (SELECT 1 FROM pacientes)
BEGIN
    INSERT INTO pacientes (codigo_paciente, nombre, cedula, fecha_nacimiento)
    VALUES 
    ('PAC001', N'Carlos Mendoza Soto', '8-745-1234', '1990-04-15'),
    ('PAC002', N'Valeria Gómez Rivas', '4-802-5678', '1997-11-23'),
    ('PAC003', N'Elena Morales Ortiz', '3-541-9876', '1962-08-30'),
    ('PAC004', N'Andrés Castillo Vega', '8-320-4321', '1979-02-10');

    INSERT INTO citas (id_paciente, fecha_cita, tipo_consulta, sintomas)
    VALUES
    (1, '2026-10-06', N'Medicina General', N'Fiebre de 38.5°C persistente por dos días, tos seca y dolor de cabeza frecuente.'),
    (2, '2026-10-06', N'Urgencias', N'Dolor agudo en articulaciones, cefalea y mareos matutinos.'),
    (3, '2026-10-07', N'Cardiología', N'Presión arterial elevada, dolor torácico leve y fatiga al caminar.'),
    (4, '2026-10-08', N'Traumatología', N'Dolor lumbar intenso tras esfuerzo físico y dificultad para agacharse.');

    PRINT 'Datos de prueba insertados con éxito.';
END
GO

-- 7. Consultar pacientes con sus citas
SELECT 
    p.id_paciente AS [ID],
    p.codigo_paciente AS [Código],
    p.nombre AS [Nombre del Paciente],
    p.cedula AS [Cédula],
    FORMAT(p.fecha_nacimiento, 'dd/MM/yyyy') AS [F. Nacimiento],
    DATEDIFF(YEAR, p.fecha_nacimiento, GETDATE()) AS [Edad Aprox.],
    c.id_cita AS [ID Cita],
    FORMAT(c.fecha_cita, 'dd/MM/yyyy') AS [Fecha Cita],
    c.tipo_consulta AS [Tipo de Consulta],
    c.sintomas AS [Síntomas]
FROM pacientes p
LEFT JOIN citas c ON p.id_paciente = c.id_paciente;
GO
