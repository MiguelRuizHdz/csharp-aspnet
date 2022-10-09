<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Tarea2.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <%-- Autor: Miguel Ruiz --%>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Calculadora .net" Font-Bold="True" Font-Size="52px" ForeColor="#3A0DB3" Font-Names="Ebrima"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" Style="border-radius: 6px" runat="server" Height="110px" Width="400px" Font-Size="40px"></asp:TextBox>
            <br />
            <asp:Button ID="btnSumar" runat="server" Text="+" BackColor="#0099FF" BorderColor="#66FFFF" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="70px" Height="100px" Width="100px" OnClick="btnSumar_Click" />
            <asp:Button ID="btnRestar" runat="server" Text="-" BackColor="#0099FF" BorderColor="#66FFFF" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="70px" Height="100px" Width="100px" OnClick="btnRestar_Click" />
            <asp:Button ID="btnMultiplicar" runat="server" Text="x" BackColor="#0099FF" BorderColor="#66FFFF" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="70px" Height="100px" Width="100px" OnClick="btnMultiplicar_Click" />
            <asp:Button ID="btnDividir" runat="server" Text="/" BackColor="#0099FF" BorderColor="#66FFFF" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="70px" Height="100px" Width="100px" />
            <br />
            <asp:Button ID="btn1" runat="server" Style="border-radius: 4px" Text="1" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn1_Click" />
            <asp:Button ID="btn2" runat="server" Style="border-radius: 4px" Text="2" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn2_Click" />
            <asp:Button ID="btn3" runat="server" Style="border-radius: 4px" Text="3" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn3_Click" />
            <asp:Button ID="btnCE" runat="server" Text="CE" BackColor="#00CC00" BorderColor="#6DFF6D" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btnCE_Click" />
            <br />
            <asp:Button ID="btn4" runat="server" Style="border-radius: 4px" Text="4" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn4_Click" />
            <asp:Button ID="btn5" runat="server" Style="border-radius: 4px" Text="5" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn5_Click" />
            <asp:Button ID="btn6" runat="server" Style="border-radius: 4px" Text="6" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn6_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="<-" BackColor="#00CC00" BorderColor="#6DFF6D" BorderStyle="Outset" BorderWidth="4px" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btnDelete_Click" />
            <br />
            <asp:Button ID="btn7" runat="server" Style="border-radius: 4px" Text="7" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn7_Click" />
            <asp:Button ID="btn8" runat="server" Style="border-radius: 4px" Text="8" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn8_Click" />
            <asp:Button ID="btn9" runat="server" Style="border-radius: 4px" Text="9" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn9_Click" />
            <asp:ImageButton ID="btnSqrt" runat="server" Height="100px" ImageUrl="~/sqrt.png" Width="100px" />
            <br />
            <asp:Button ID="btn0" runat="server" Style="border-radius: 4px" Text="0" Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btn0_Click" />
            <asp:Button ID="btnDot" runat="server" Style="border-radius: 4px" Text="." Font-Bold="True" Font-Size="55px" Height="100px" Width="100px" OnClick="btnDot_Click" />
            <asp:Button ID="btnResultado" runat="server" Style="border-radius: 4px" Text="=" Font-Bold="True" Font-Size="55px" Height="100px" Width="200px" OnClick="btnResultado_Click" />
            <br />
        </div>
    </form>
</body>
</html>
