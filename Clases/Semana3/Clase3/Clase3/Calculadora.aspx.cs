using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class Calculadora : System.Web.UI.Page
    {
        double Valor1, Valor2, Resultado;
        String Operador;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            Valor1 = double.Parse(TextBox1.Text);
            Operador = "+";
            TextBox1.Text = "";
            ViewState["Valor1"] = Valor1;
            ViewState["Operador"] = Operador;
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            Valor1 = double.Parse(TextBox1.Text);
            Operador = "-";
            TextBox1.Text = "";
            ViewState["Valor1"] = Valor1;
            ViewState["Operador"] = Operador;
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Valor1 = double.Parse(TextBox1.Text);
            Operador = "*";
            TextBox1.Text = "";
            ViewState["Valor1"] = Valor1;
            ViewState["Operador"] = Operador;

        }

        protected void btnSqrt_Click(object sender, ImageClickEventArgs e)
        {
            Operador = "raiz";
            Valor1 = double.Parse(TextBox1.Text);
            TextBox1.Text = Math.Sqrt(Valor1).ToString();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";

        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";

        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";

        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        protected void btnDot_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";
        }

        protected void btnCE_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 1)
            {
                TextBox1.Text = "";
            }
            else
            {
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
            }
        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(ViewState["Valor1"]);
            Operador = Convert.ToString(ViewState["Operador"]);
            if(TextBox1.Text != "")
            {
                Valor2 = Double.Parse(TextBox1.Text);

                switch (Operador)
                {
                    case "+":
                        Resultado = Valor1 + Valor2;
                        TextBox1.Text = Resultado.ToString();
                        break;
                    case "*":
                        Resultado = Valor1 * Valor2;
                        TextBox1.Text = Resultado.ToString();
                        break;
                    case "-":
                        Resultado = Valor1 - Valor2;
                        TextBox1.Text = Resultado.ToString();
                        break;
                    case "/":
                        if (Valor2 != 0)
                        {
                            Resultado = Valor1 + Valor2;
                            TextBox1.Text = Resultado.ToString();
                        }
                        else
                        {
                            TextBox1.Text = "Error";
                        }
                        break;
                    default:
                        Resultado = 0;
                        TextBox1.Text = btnResultado.ToString();
                        break;

                }
            }
        }

        
    }
}