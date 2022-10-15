using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_clase.Entidades
{
    public class eAlumno
    {
        public eAlumno()
        { }

        public int AlumnoId { get => _AlumnoId; set => _AlumnoId = value; } 
        public int Matricula { get => _Matricula; set => _Matricula = value; } 
        public string Nombre { get => _Nombre; set => _Nombre = value; } 
        public string Direccion { get => _Direccion; set => _Direccion = value; } 
        public string GeneroId { get => _GeneroId; set => _GeneroId = value; } 
        public string Telefono { get => _Telefono; set => _Telefono = value; } 
        public string Correo { get => _Correo; set => _Correo = value; } 
        public string CURP { get => _CURP; set => _CURP = value; } 
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; } 
        //public DateTime FechaNacimiento1 { get => _FechaNacimiento1; set => _FechaNacimiento1 = value; } 
        public string Estatus { get => _Estatus; set => _Estatus = value; } 
        private int _AlumnoId;
        private int _Matricula;
        private string _Nombre;
        private string _Direccion;
        private string _GeneroId;
        private string _Telefono;
        private string _Correo;
        private string _CURP;
        private DateTime _FechaNacimiento;
        private string _Estatus;

        public eAlumno( int alumnoid, int matricula, string nombre, string direccion,
                        string generoid, string telefono, string correo,
                        string curp, DateTime fechaNacimiento, string estatus )
        {
            _AlumnoId = alumnoid;
            _Matricula = matricula;
            _Nombre = nombre;
            _Direccion = direccion;
            _GeneroId = generoid;
            _Telefono = telefono;
            _Correo = correo;
            _CURP = curp;
            _FechaNacimiento = fechaNacimiento;
            _Estatus = estatus;
        }

    }
}