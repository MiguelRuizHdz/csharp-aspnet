using Proyecto_clase.Entidades;
using Proyecto_clase.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_clase.Presentacion
{
    public partial class Alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        protected void ActualizarGrid()
        {
            nAlumno negocio = new nAlumno();
            grvAlumno.DataSource = negocio.AlumnosConsulta();
            grvAlumno.DataBind();
        }

        protected void imbLimpiar_Click(object sender, ImageClickEventArgs e)
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCURP.Text = "";
            txtFechaNacimiento.Text = "";
        }

        protected void btnCalendario_Click(object sender, ImageClickEventArgs e)
        {
            if (calFecha.Visible == true)
                calFecha.Visible = false;
            else
                calFecha.Visible = true;
        }

        protected void calFecha_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = string.Format("{0:dd/MM/yyyy}", calFecha.SelectedDate);
            calFecha.Visible = false;
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            eAlumno alumno = new eAlumno();
            nAlumno negocio = new nAlumno();

            alumno = negocio.AlumnosConsultaXMat(int.Parse(txtMatricula.Text));

            if (alumno.Matricula > 0 )
            {
                txtMatricula.Text = alumno.Matricula.ToString();
                txtNombre.Text = alumno.Nombre.ToString();
                txtDireccion.Text = alumno.Direccion.ToString();
                txtTelefono.Text = alumno.Telefono.ToString();
                txtCorreo.Text = alumno.Correo.ToString();
                txtCURP.Text = alumno.CURP.ToString();
                txtFechaNacimiento.Text = alumno.FechaNacimiento.ToString();

                if (alumno.GeneroId == "M")
                {
                    this.rblGenero.SelectedValue = "M";
                }
                else
                {
                    this.rblGenero.SelectedValue = "F";
                }
            }
        }

        protected void imbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            // Response.Write("<script language=javascript>alert('hola');</script>");
            eAlumno alumno = new eAlumno();
            alumno.Matricula = int.Parse(this.txtMatricula.Text);
            alumno.Nombre = this.txtNombre.Text.ToString();
            alumno.Direccion = this.txtDireccion.Text.ToString();
            alumno.Telefono = this.txtTelefono.Text.ToString();
            alumno.Correo = this.txtCorreo.Text.ToString();
            alumno.CURP = this.txtCURP.Text.ToString();
            alumno.FechaNacimiento = Convert.ToDateTime(this.txtFechaNacimiento.Text);
            alumno.Estatus = "1";
            if (this.rblGenero.SelectedValue == "M")
            {
                alumno.GeneroId = "M";
            }
            else
            {
                alumno.GeneroId = "F";
            }
            
            int alumnoAgregado;
            nAlumno negocio = new nAlumno();
            alumnoAgregado = negocio.AgregarAlumno(alumno);
            if (alumnoAgregado > 0)
            {
                Response.Write("<script language=javascript>alert('Registro Agregado correctamente');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('No se pudo agregar el registro');</script>");
            }
            ActualizarGrid();
        }

        protected void imbEliminar_Click(object sender, ImageClickEventArgs e)
        {
            eAlumno alumno = new eAlumno();
            alumno.Matricula = int.Parse(this.txtMatricula.Text);

            int alumnoEliminado;

            nAlumno negocio = new nAlumno();
            alumnoEliminado = negocio.AlumnoBorra(alumno.Matricula);
            if (alumnoEliminado > 0)
            {
                Response.Write("<script language=javascript>alert('Registro Eliminado correctamente');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('No se pudo eliminarl el registro');</script>");
            }
            ActualizarGrid();
        }

        protected void imbEditar_Click(object sender, ImageClickEventArgs e)
        {
            eAlumno alumno = new eAlumno();
            alumno.Matricula = int.Parse(this.txtMatricula.Text);
            alumno.Nombre = this.txtNombre.Text.ToString();
            alumno.Direccion = this.txtDireccion.Text.ToString();
            alumno.Telefono = this.txtTelefono.Text.ToString();
            alumno.Correo = this.txtCorreo.Text.ToString();
            alumno.CURP = this.txtCURP.Text.ToString();
            alumno.FechaNacimiento = Convert.ToDateTime(this.txtFechaNacimiento.Text);
            alumno.Estatus = "1";
            if (this.rblGenero.SelectedValue == "M")
            {
                alumno.GeneroId = "M";
            }
            else
            {
                alumno.GeneroId = "F";
            }

            int alumnoModificado;
            nAlumno negocio = new nAlumno();
            alumnoModificado = negocio.AlumnoModifica(alumno);
            if (alumnoModificado > 0)
            {
                Response.Write("<script language=javascript>alert('Registro editado correctamente');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('No se pudo editar el registro');</script>");
            }
            ActualizarGrid();
        }
    }
}