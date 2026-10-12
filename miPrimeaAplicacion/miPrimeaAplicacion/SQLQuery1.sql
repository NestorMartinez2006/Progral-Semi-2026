-- 1. Eliminar todas las restricciones de claves foráneas en la base de datos para evitar bloqueos
DECLARE @sql NVARCHAR(MAX) = N'';
SELECT @sql += N'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
               N' DROP CONSTRAINT ' + QUOTENAME(name) + N';'
FROM sys.foreign_keys;
EXEC sp_executesql @sql;

-- 2. Ahora sí podemos eliminar las tablas sin problemas de dependencias
DROP TABLE IF EXISTS notas;
DROP TABLE IF EXISTS materias;
DROP TABLE IF EXISTS matricula;

-- 3. Volver a crear la tabla materias con idMateria autoincrementable (IDENTITY)
CREATE TABLE materias (
    idMateria INT IDENTITY(1,1) PRIMARY KEY,
    [código] VARCHAR(50) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    uv INT NOT NULL
);

-- 4. Volver a crear la tabla notas con sus respectivas relaciones
CREATE TABLE notas (
    idNota INT IDENTITY(1,1) PRIMARY KEY,
    idAlumno INT FOREIGN KEY REFERENCES alumnos(idAlumnos),
    idMateria INT FOREIGN KEY REFERENCES materias(idMateria),
    idPeriodo INT FOREIGN KEY REFERENCES periodos(idPeriodo),
    fecha DATETIME
);