<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinAjax.aspx.cs" Inherits="Proyecto_clase.Ajax.SinAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <iframe width="560" height="315" src="https://www.youtube.com/embed/NMNgbISmF4I" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver comentarios" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
