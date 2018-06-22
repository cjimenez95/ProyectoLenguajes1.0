<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="Presentacion.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 97px;
        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 232px;
        }
        .auto-style5 {
            width: 126px;
            height: 42px;
        }
        .auto-style6 {
            width: 232px;
            height: 42px;
        }
        .auto-style7 {
            height: 42px;
        }
        .auto-style8 {
            width: 126px;
            height: 43px;
        }
        .auto-style9 {
            width: 232px;
            height: 43px;
        }
        .auto-style10 {
            height: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lb_iniciarSesion" runat="server" Text="Iniciar sesión"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lb_codigoUsuario" runat="server" Text="Codigo de usuario: "></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txt_codigoUsuario" runat="server" CssClass="auto-style3" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="lb_contrasena" runat="server" Text="Contraseña: "></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox type="password" ID="txt_contrasena" runat="server" OnTextChanged="txt_contrasena_TextChanged" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="bt_ingresar" runat="server" Text="Ingresar" OnClick="bt_ingresar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
