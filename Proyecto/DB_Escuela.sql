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


CREATE PROCEDURE AlumnoAgrega
@Matricula int,
@Nombre VARCHAR(10),
@CURP VARCHAR(18),
@FechaNacimiento DATETIME,
@Direccion VARCHAR(10),
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
