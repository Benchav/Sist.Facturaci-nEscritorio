<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alicia.aspx.cs" Inherits="Alicia.Alicia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Employees" runat="server">
       <b> Web Panaderia y Reposteria Alici</b><p>
            <asp:Label ID="lblNUsuario" runat="server" Text="Nombre "></asp:Label>
            <asp:TextBox ID="txtUsua" runat="server" Width="184px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
        <asp:CheckBox ID="ckMasculino" runat="server" Text="Masculino" />
        <asp:CheckBox ID="ckFemenino" runat="server" Text="Femenino" />
        <br />
        <p>
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEstudios" runat="server" Text="Estudios"></asp:Label>
            <asp:DropDownList ID="DpEducacion" runat="server" Height="17px" Width="183px">
                <asp:ListItem>Primaria</asp:ListItem>
                <asp:ListItem>Secundaria</asp:ListItem>
                <asp:ListItem>Universidad</asp:ListItem>
                <asp:ListItem>Maestria</asp:ListItem>
                <asp:ListItem>Doctorado</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblUsuario1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuarion" runat="server" Width="177px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server" Width="154px"></asp:TextBox>
        </p>
        <asp:Label ID="lblConfirmar" runat="server" Text="Confirmar contraseña"></asp:Label>
        <asp:TextBox ID="txtconfirmarcontra" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
        </p>
        <asp:GridView ID="GdUsuario" runat="server" Height="175px" Width="696px">
        </asp:GridView>
    </form>
</body>
</html>
