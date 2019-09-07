CREATE DATABASE EstudiantesDb
GO 
USE EstudiantesDb
GO
CREATE TABLE Estudiant
(
    EstudianteId int primary key identity(1,1),
	Matricula  varchar(9),
	Nombres varchar(30),
	Apellidos varchar(30),
	Cedula varchar(30),
	Telefono varchar(13),
	Celular varchar(13),
	Email varchar(40),
	FechaNacimiento date,
	Sexo varchar(15),
	Balance varchar(max)
);


