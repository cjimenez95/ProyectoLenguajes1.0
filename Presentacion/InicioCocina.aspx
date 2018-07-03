<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioCocina.aspx.cs" Inherits="Presentacion.InicioCocina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1"
        EnablePageMethods="true"
        EnablePartialRendering="true" runat="server" />
    <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
    </asp:Timer>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridCocina" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridCocina_RowDataBound" OnRowCommand="GridCocina_RowCommand" OnSelectedIndexChanged="GridCocina_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="PedidoID" HeaderText="Numero Pedido" />
                <asp:BoundField DataField="NombreUsusario" HeaderText="Nombre Cliente" />
                <asp:BoundField DataField="ESTADO" HeaderText="Estado del Pedido" />
                <asp:TemplateField HeaderText="Platos">
                    <ItemTemplate>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Nombre" HeaderText="Plato" />
                                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="Especificacion" HeaderText="Indicacion" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="Button_Entrega" runat="server" Text="Entrega" OnClientClick="validarEntrega()" CommandName="seleccion"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
    <p>
        <script type="text/javascript">

            function validarEntrega() {
                if (confirm("¿Desea confirmar entrega?") == true) {
                    PageMethods.obtenerValorConfirmacion(true);
                } else {
                    PageMethods.obtenerValorConfirmacion(false);
                }
            }
        </script>
    </p>
</asp:Content>
