<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioCocina.aspx.cs" Inherits="Presentacion.InicioCocina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:GridView ID="GridCocina" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridCocina_RowDataBound">
            <Columns>
                <asp:BoundField DataField="PedidoID" HeaderText="Numero Pedido" />
                <asp:BoundField DataField="NombreUsusario" HeaderText="Nombre Cliente" />
                <asp:BoundField DataField="ESTADO" HeaderText="Estado del Pedido" />
                <asp:TemplateField HeaderText="Platos">
                    <ItemTemplate>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Nombre" HeaderText="Plato" />
                                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="Especificacion" HeaderText="Indicacion" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
</asp:Content>
