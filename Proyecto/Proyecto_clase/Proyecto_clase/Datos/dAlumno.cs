using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using Proyecto_clase.Entidades;

namespace Proyecto_clase.Datos
{
    public class dAlumno
    {
        public dAlumno()
        { }
        public static string constr
        {
            get { return ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString; }
        }
        public static string Proveedor
        {
            get { return ConfigurationManager.ConnectionStrings["Conexion"].ProviderName; }
        }

        public static DbProviderFactory dpf
        {
            get { return DbProviderFactories.GetFactory(Proveedor); }
        }
        private static int ejecutaNonQuery(string storeProcedured,
                    List<DbParameter> parametros)
        {
            int Id = 0;
            try
            {
                using (DbConnection con = dpf.CreateConnection())
                {
                    con.ConnectionString = constr; 
                    using (DbCommand cmd = dpf.CreateCommand())
                    {
                        cmd.Connection = con; 
                        cmd.CommandText = storeProcedured; 
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (DbParameter parametro in parametros)
                        {
                            cmd.Parameters.Add(parametro);
                        }
                        con.Open(); 
                        Id = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return Id;
        }
        
        private static List<eAlumno> ejecutaDataReader(string storeProcedured)
        {
            DataTable dt = new DataTable();
            List<eAlumno> lstAlumno = new List<eAlumno>();
            try
            {
                using (DbConnection con = dpf.CreateConnection())
                {
                    con.ConnectionString = constr;
                    using (DbCommand cmd = dpf.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = storeProcedured;
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstAlumno.Add( new eAlumno(
                                    (int)reader["AlumnoId"],
                                    (int)reader["Matricula"],
                                    (string)reader["Nombre"],
                                    (string)reader["Direccion"],
                                    (string)reader["GeneroId"],
                                    (string)reader["Telefono"],
                                    (string)reader["Correo"],
                                    (string)reader["CURP"],
                                    (DateTime)reader["FechaNacimiento"],
                                    (string)reader["Estatus"]
                                ));
                            }
                            return lstAlumno;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private static eAlumno ejecutaDataReader(string storeProcedured, List<DbParameter> parametros)
        {
            DataTable dt = new DataTable();
            eAlumno Alumno = new eAlumno();
            try
            {
                using (DbConnection con = dpf.CreateConnection())
                {
                    con.ConnectionString = constr;
                    using (DbCommand cmd = dpf.CreateCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = storeProcedured;
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (DbParameter parametro in parametros)
                        {
                            cmd.Parameters.Add(parametro);
                        }
                        con.Open();
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Alumno.AlumnoId = (int)reader["AlumnoId"];
                                Alumno.Matricula = (int)reader["Matricula"];
                                Alumno.Nombre = (string)reader["Nombre"];
                                Alumno.Direccion = (string)reader["Direccion"];
                                Alumno.GeneroId = (string)reader["GeneroId"];
                                Alumno.Telefono = (string)reader["Telefono"];
                                Alumno.Correo = (string)reader["Correo"];
                                Alumno.CURP = (string)reader["CURP"];
                                Alumno.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                                Alumno.Estatus = (string)reader["Estatus"];
                            }
                            return Alumno;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int AlumnoAgregar(eAlumno alumno)
        {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param01 = dpf.CreateParameter();
            param01.Value = alumno.Matricula;
            param01.ParameterName = "Matricula";
            parametros.Add(param01);
            DbParameter param02 = dpf.CreateParameter();
            param02.Value = alumno.Nombre;
            param02.ParameterName = "Nombre";
            parametros.Add(param02);
            DbParameter param03 = dpf.CreateParameter();
            param03.Value = alumno.Direccion;
            param03.ParameterName = "Direccion";
            parametros.Add(param03);
            DbParameter param04 = dpf.CreateParameter();
            param04.Value = alumno.GeneroId;
            param04.ParameterName = "GeneroId";
            parametros.Add(param04);
            DbParameter param05 = dpf.CreateParameter();
            param05.Value = alumno.Telefono;
            param05.ParameterName = "Telefono";
            parametros.Add(param05);
            DbParameter param06 = dpf.CreateParameter();
            param06.Value = alumno.Correo;
            param06.ParameterName = "Correo";
            parametros.Add(param06);
            DbParameter param07 = dpf.CreateParameter();
            param07.Value = alumno.FechaNacimiento;
            param07.ParameterName = "FechaNacimiento";
            parametros.Add(param07);
            DbParameter param08 = dpf.CreateParameter();
            param08.Value = alumno.CURP;
            param08.ParameterName = "CURP";
            parametros.Add(param08);
            try
            {
                return ejecutaNonQuery("AlumnoAgrega", parametros);
            }
            catch { return 0; }
        }

        public List<eAlumno> AlumnoConsulta()
        {
            List<DbParameter> parametros = new List<DbParameter>();
            return ejecutaDataReader("AlumnoConsulta");
        }

        public eAlumno AlumnoConsultaXMat(int matricula)
        {
            // Lista que contendra los valores a agregar al SP
            List<DbParameter> parametros = new List<DbParameter>(); 
            //Parametro Ingresado a SP
            DbParameter param01 = dpf.CreateParameter();
            param01.Value = matricula;
            param01.ParameterName = "Matricula";
            parametros.Add(param01);
            // Ejecuta y regresa el valor del DataReader
            return ejecutaDataReader("AlumnoConsultaXMatricula", parametros);
        }

    }
}