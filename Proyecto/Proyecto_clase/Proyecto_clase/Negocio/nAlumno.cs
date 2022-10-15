using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Proyecto_clase.Datos;
using Proyecto_clase.Entidades;

namespace Proyecto_clase.Negocio
{
    public class nAlumno
    {
        dAlumno datos = new dAlumno();

        public int AgregarAlumno(eAlumno alumno)
        {
            return datos.AlumnoAgregar(alumno);
        }

        public List<eAlumno> AlumnosConsulta()
        {
            return datos.AlumnoConsulta();
        }
        
        public eAlumno AlumnosConsultaXMat(int matricula)
        {
            return datos.AlumnoConsultaXMat(matricula);
        }

        public int AlumnoBorra(int matricula)
        {
            return datos.AlumnoBorra(matricula);
        }

        public int AlumnoModifica(eAlumno alumno)
        {
            return datos.AlumnoModifica(alumno);
        }


    }
}