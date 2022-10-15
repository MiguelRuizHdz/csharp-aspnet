CREATE TABLE [dbo].[Alumno]
(
	[AlumnoId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Matricula] INT NOT NULL, 
    [Nombre] VARCHAR(100) NOT NULL, 
    [CURP] VARCHAR(18) NOT NULL, 
    [FechaNacimiento] DATETIME NOT NULL, 
    [Direccion] VARCHAR(100) NOT NULL, 
    [Telefono] VARCHAR(20) NULL, 
    [GeneroId] NCHAR(1) NULL, 
    [Correo] VARCHAR(50) NULL, 
    [Estatus] NCHAR(1) NULL,
	CONSTRAINT pk_Alumno primary key (Matricula)
)

CREATE TABLE [dbo].[Materia]
(
	[MateriaId] INT NOT NULL,
    [Materia] VARCHAR(50) NOT NULL,
    [Estatus] BIT NULL,
	CONSTRAINT pk_Materia primary key (MateriaId)
)

CREATE TABLE [dbo].[Maestro]
(
	[MaestroId] INT IDENTITY(1,1) NOT NULL,
    [Clave] INT NOT NULL,
    [Nombre] VARCHAR(100) NOT NULL, 
    [Direccion] VARCHAR(100) NOT NULL, 
    [Telefono] VARCHAR(20) NULL, 
    [Correo] VARCHAR(50) NULL, 
    [Estatus] BIT NULL,
	CONSTRAINT pk_Maestro primary key (MaestroId)
)

CREATE TABLE [dbo].[Grupo]
(
	[GrupoId] INT NOT NULL IDENTITY,
    [Grupo] VARCHAR(20) NOT NULL,
	[MaestroId] INT NOT NULL,
	[MateriaId] INT NOT NULL,
	[Matricula] INT NOT NULL,
    [Estatus] BIT,
	CONSTRAINT pk_Grupo primary key (GrupoId),
	CONSTRAINT fk_Grupo_Maestro foreign key (MaestroId)
    references Maestro (MaestroId),
	CONSTRAINT fk_Grupo_Materia foreign key (MateriaId)
    references Materia (MateriaId),
	CONSTRAINT fk_Grupo_Alumno foreign key (Matricula)
    references Alumno (Matricula)
)


CREATE PROCEDURE AlumnoAgrega
@Matricula int,
@Nombre VARCHAR(100),
@CURP VARCHAR(18),
@FechaNacimiento DATETIME,
@Direccion VARCHAR(100),
@Telefono VARCHAR(20),
@GeneroId NCHAR(1),
@Correo VARCHAR(50),
@Estatus NCHAR(1)

AS
If not exists (Select Matricula from Alumno where Matricula = @Matricula)

Begin

Insert into Alumno (Matricula, Nombre, CURP, FechaNacimiento, Direccion, Telefono, GeneroId, Correo, Estatus)
values
(@Matricula, @Nombre, @CURP, @FechaNacimiento, @Direccion, @Telefono, @GeneroId, @Correo, @Estatus)
End
Return 0



CREATE PROCEDURE AlumnoConsulta
AS
select AlumnoId, Matricula, Nombre, CURP, FechaNacimiento, Direccion, Telefono, GeneroId, Correo, Estatus
from Escuela.dbo.Alumno


CREATE PROCEDURE AlumnoConsultaXMatricula
@Matricula int
AS
select AlumnoId, Matricula, Nombre, CURP, FechaNacimiento, Direccion, Telefono, GeneroId, Correo, Estatus
from Escuela.dbo.Alumno
where
Matricula = @Matricula

CREATE PROCEDURE AlumnoElimina
@Matricula int
AS
DELETE
FROM Escuela.dbo.Alumno
WHERE
Matricula = @Matricula;
Return 0

CREATE PROCEDURE AlumnoModifica
@Matricula int,
@Nombre VARCHAR(100),
@CURP VARCHAR(18),
@FechaNacimiento DATETIME,
@Direccion VARCHAR(100),
@Telefono VARCHAR(20),
@GeneroId NCHAR(1),
@Correo VARCHAR(50),
@Estatus NCHAR(1)
AS
If exists (Select Matricula from Alumno where Matricula = @Matricula)
Begin
UPDATE dbo.Alumno 
SET 
Nombre = @Nombre, CURP = @CURP, FechaNacimiento = @FechaNacimiento, Direccion = @Direccion, Telefono = @Telefono, GeneroId = @GeneroId, Correo = @Correo, Estatus = @Estatus
where Matricula =  @Matricula
End
Return 0