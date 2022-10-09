using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase2
{
    public partial class Practica1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = "Hola, mucho gusto " + TextBox1.Text;
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBox2.Text);
            int valor2 = int.Parse(TextBox3.Text);

            int suma = valor1 + valor2;

            Label5.Text = "El resultado de la suma es " + suma.ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBox2.Text);
            int valor2 = int.Parse(TextBox3.Text);

            int resta = valor1 - valor2;

            Label6.Text = "El resultado de la resta es " + resta.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBox4.Text);
            int valor2 = int.Parse(TextBox5.Text);

            if (RadioButton1.Checked)
            {
                int resultado = valor1 + valor2;
                Label7.Text = "El resultado de la suma es " + resultado.ToString();
            } else if (RadioButton2.Checked)
            {
                int resultado = valor1 - valor2;
                Label7.Text = "El resultado de la resta es " + resultado.ToString();
            } else
            {
                Label7.Text = "Escoge una operación";
                Label7.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBox6.Text);
            int valor2 = int.Parse(TextBox7.Text);

            Label8.Text = "";
            Label9.Text = "";

            if (CheckBox1.Checked)
            {
                int resultado = valor1 + valor2;
                Label8.Text = "El resultado de la suma es " + resultado.ToString();
            }
            if (CheckBox2.Checked)
            {
                int resultado = valor1 - valor2;
                Label9.Text = "El resultado de la resta es " + resultado.ToString();
            }
            if (!CheckBox1.Checked && !CheckBox2.Checked)
            {
                Label8.Text = "Escoge una operación";
                Label8.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}