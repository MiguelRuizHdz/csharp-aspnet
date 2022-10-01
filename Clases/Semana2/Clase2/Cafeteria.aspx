<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Cafeteria.aspx.cs" Inherits="Clase2.Cafeteria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cafetería .NET</h1>
            <br />
            <h4>Lo atiende desde el 2022 nuestro alumno Miguel Ruiz</h4>

            <table class="table table-dark table-sm">
                <thead>
                    <tr style="background-color:darkgray">
                        <th>Producto</th>
                        <th>Precio</th>
                        <th>Cantidad</th>
                        <th>Importe</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Refresco</td>
                        <td>$ <asp:Label ID="Label1" runat="server" Text="15"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Burrito</td>
                        <td>$ <asp:Label ID="Label2" runat="server" Text="25"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Hamburguesa</td>
                        <td>$ <asp:Label ID="Label3" runat="server" Text="45"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Papas a la francesa</td>
                        <td>$ <asp:Label ID="Label4" runat="server" Text="38"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Comida corrida</td>
                        <td>$ <asp:Label ID="Label5" runat="server" Text="60"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Tacos</td>
                        <td>$ <asp:Label ID="Label6" runat="server" Text="40"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Coctel de frutas</td>
                        <td>$ <asp:Label ID="Label7" runat="server" Text="50"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Jugo</td>
                        <td>$ <asp:Label ID="Label8" runat="server" Text="12"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox15" runat="server"></asp:TextBox></td>
                        <td>$ <asp:TextBox ID="TextBox16" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                </tbody>
                <tfooter>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="Button1" runat="server" Text="Realizar pedido" OnClick="Button1_Click" /></td>
                        <td><b>Subtotal</b></td>
                        <td>$ <asp:TextBox ID="TextBox17" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td><b>Descuento</b></td>
                        <td>$ <asp:TextBox ID="TextBox18" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="Button2" runat="server" Text="Limpiar" OnClick="Button2_Click" /></td>
                        <td><b>Total</b></td>
                        <td>$ <asp:TextBox ID="TextBox19" runat="server" ReadOnly="True"  BorderStyle="None"></asp:TextBox></td>
                    </tr>
                </tfooter>
            </table>
        </div>
    </form>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</body>
</html>
