using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase2
{
    public partial class Cafeteria : System.Web.UI.Page
    {
        // Autor: Miguel Ruiz
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") TextBox1.Text = "0";
            if (TextBox3.Text == "") TextBox3.Text = "0";
            if (TextBox5.Text == "") TextBox5.Text = "0";
            if (TextBox7.Text == "") TextBox7.Text = "0";
            if (TextBox9.Text == "") TextBox9.Text = "0";
            if (TextBox11.Text == "") TextBox11.Text = "0";
            if (TextBox13.Text == "") TextBox13.Text = "0";
            if (TextBox15.Text == "") TextBox15.Text = "0";

            int refresco = int.Parse(TextBox1.Text) * int.Parse(Label1.Text);
            TextBox2.Text = refresco.ToString(); 

            int burrito = int.Parse(TextBox3.Text) * int.Parse(Label2.Text);
            TextBox4.Text = burrito.ToString(); 
            
            int hamburguesa = int.Parse(TextBox5.Text) * int.Parse(Label3.Text);
            TextBox6.Text = hamburguesa.ToString(); 

            int papas = int.Parse(TextBox7.Text) * int.Parse(Label4.Text);
            TextBox8.Text = papas.ToString(); 

            int comida = int.Parse(TextBox9.Text) * int.Parse(Label5.Text);
            TextBox10.Text = comida.ToString(); 

            int tacos = int.Parse(TextBox11.Text) * int.Parse(Label6.Text);
            TextBox12.Text = tacos.ToString(); 

            int coctel = int.Parse(TextBox13.Text) * int.Parse(Label7.Text);
            TextBox14.Text = coctel.ToString(); 

            int jugo = int.Parse(TextBox15.Text) * int.Parse(Label8.Text);
            TextBox16.Text = jugo.ToString();

            int sub = int.Parse(TextBox2.Text) + int.Parse(TextBox4.Text) + int.Parse(TextBox6.Text) + int.Parse(TextBox8.Text) + int.Parse(TextBox10.Text) + int.Parse(TextBox12.Text) + int.Parse(TextBox14.Text) + int.Parse(TextBox16.Text);
            int sub1 = refresco + burrito + hamburguesa + papas + comida + tacos + coctel + jugo;
            TextBox17.Text = sub.ToString();

            if (sub > 300)
            {
                double desc = sub * 0.01;
                TextBox18.Text = desc.ToString();
                double total = sub - desc;
                TextBox19.Text = total.ToString();
            } else {
                double desc = 0;
                TextBox18.Text = desc.ToString();
                double total = sub;
                TextBox19.Text = total.ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
        }
    }
}