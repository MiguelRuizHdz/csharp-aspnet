<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto_clase.Presentacion.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Autor: Miguel Ruiz --%>
    <h2>EDUCACION CONTINUA</h2>
    <table>
        <tr>
            <td><asp:Label ID="lblMatricula" runat="server" Text="Matricula:"></asp:Label></td>
            <td><asp:TextBox ID="txtMatricula" runat="server" Width="225px"></asp:TextBox></td>
            <td>
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Imagenes/search.png" />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></td>
            <td><asp:TextBox ID="txtNombre" runat="server" Width="225px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label></td>
            <td><asp:TextBox ID="txtDireccion" runat="server" Width="225px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblGenero" runat="server" Text="Genero:"></asp:Label></td>
            <td>
                <asp:RadioButton ID="RadioButton1" Text="Masculino" GroupName="rblGenero" runat="server" />
                <asp:RadioButton ID="RadioButton2" Text="Femenino" GroupName="rblGenero" runat="server" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label></td>
            <td><asp:TextBox ID="txtTelefono" runat="server" Width="225px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label></td>
            <td><asp:TextBox ID="txtCorreo" runat="server" Width="225px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblCURP" runat="server" Text="CURP:"></asp:Label></td>
            <td><asp:TextBox ID="txtCURP" runat="server" Width="225px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento:"></asp:Label></td>
            <td><asp:TextBox ID="txtFechaNacimiento" runat="server" Width="225px"></asp:TextBox></td>
            <td>
                <asp:ImageButton ID="btnCalendario" runat="server" ImageUrl="~/Imagenes/calendario.png" />
            </td>
        </tr><tr>
            <td></td>
            <td><asp:Calendar ID="calFecha" runat="server"></asp:Calendar></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td style="text-align: center;">
                <asp:ImageButton ID="imbEditar" runat="server" ImageUrl="~/Imagenes/edit.png" />
                &nbsp;&nbsp;
                <asp:ImageButton ID="imbEliminar" runat="server" ImageUrl="~/Imagenes/delete.png" />
                &nbsp;&nbsp;
                <asp:ImageButton ID="imbLimpiar" runat="server" ImageUrl="~/Imagenes/clear.png" />
                &nbsp;&nbsp;
                <asp:ImageButton ID="imbGuardar" runat="server" ImageUrl="~/Imagenes/save.png" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:GridView ID="grvAlumno" runat="server"></asp:GridView>
</asp:Content>
