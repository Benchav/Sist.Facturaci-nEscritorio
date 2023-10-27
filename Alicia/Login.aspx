<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Alicia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <b> Inicio de sesion</b>
        </div>
        <asp:Label ID="txtNusuario" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtUsuarion" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblContraseña" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnIniciar" runat="server" Text="inciar sesion" />
    </form>
</body>
</html>
