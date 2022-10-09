<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Practica1.aspx.cs" Inherits="Clase2.Practica1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>

    <html>
    <head>
        <!-- CSS only -->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <%-- Autor: Miguel Ruiz --%>
        <form id="form1">
            <table border="1">
                <tr>
                    <td>
                        Ejemplo 1
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Bienvenidos"></asp:Label>
                        <p>
                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                        </p>
                        <asp:Label ID="Label2" runat="server" Text="Introduce tu nombre"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" placeholder="Introduce tu nombre" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Ejecutar" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        Ejemplo 2
                        <br />
                        Suma o resta de dos valores
                        <br />
                        <br />
                         Valor 1:
                        <asp:TextBox ID="TextBox2" placeholder="Introduce Valor 1" runat="server"></asp:TextBox>
                        <br />
                        Valor 2:
                        <asp:TextBox ID="TextBox3" placeholder="Introduce Valor 2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="SUMA" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="RESTA" OnClick="Button3_Click" />
                        <br />

                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        Ejemplo 3
                        <br />
                        Suma o resta de dos valores
                        <br />
                        <br />
                         Valor 1:
                        <asp:TextBox ID="TextBox4" placeholder="Introduce Valor 1" runat="server"></asp:TextBox>
                        <br />
                        Valor 2:
                        <asp:TextBox ID="TextBox5" placeholder="Introduce Valor 2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:RadioButton ID="RadioButton1" Text="SUMA" GroupName="Radio" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" Text="RESTA" GroupName="Radio" runat="server" />
                        <br />

                        <asp:Button ID="Button4" runat="server" Text="Respuesta" OnClick="Button4_Click" />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>

                    </td>
                    <td>
                        Ejemplo 4
                        <br />
                        Suma o resta de dos valores check
                        <br />
                        <br />
                         Valor 1:
                        <asp:TextBox ID="TextBox6" placeholder="Introduce Valor 1" runat="server"></asp:TextBox>
                        <br />
                        Valor 2:
                        <asp:TextBox ID="TextBox7" placeholder="Introduce Valor 2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:CheckBox ID="CheckBox1" Text="SUMA" runat="server" />
                        <br />
                        <asp:CheckBox ID="CheckBox2" Text="RESTA" runat="server" />
                        <br />
                        <asp:Button ID="Button5" runat="server" Text="Respuesta" OnClick="Button5_Click" />
                        <br />
                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

            </table>
        </form>
    </body>
    </html>
</asp:Content>
