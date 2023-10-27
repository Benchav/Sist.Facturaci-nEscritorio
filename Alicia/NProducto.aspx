<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NProducto.aspx.cs" Inherits="Alicia.NProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <b> Agregar Producto</b></div>
                   
        <asp:Label ID="lblproducto" runat="server" Text="Nombre del producto"></asp:Label>
        <asp:TextBox ID="txtNProducto" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lbldescripcionpro" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        </p>
                   
    </form>
</body>
</html>
