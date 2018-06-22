<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Presentacion.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="TipoUsuario" runat="server" Text="Tipo Usuario:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tipo_Usuario" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="NombreUsuario" runat="server" Text="Nombre Usuario:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Nombre_Usuario" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="telefono" runat="server" Text="Telefono:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="telefono_" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Direccion" runat="server" Text="Direccion:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Direccion_" runat="server"></asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Label ID="Habilitado" runat="server" Text="Habilitado:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="124px">
        <asp:ListItem Value="true">Habilitado</asp:ListItem>
        <asp:ListItem Value="false">No Habilitado</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Contraseña" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="contrasena" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="ConfiarmarContraseña" runat="server" Text="Confirmar Contraseña:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Agregar" runat="server" OnClick="Agregar_Click" Text="Agregar" />
    <br />
</asp:Content>
