<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_s.aspx.cs" Inherits="Escuela.Facultades.facultad_s" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="grd_facultades" AutoGenerateColumns="false" runat="server" OnRowCommand="grd_facultades_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Imagenes/editar.png" Height="20px" Width="20px"
                        CommandName="Editar" CommandArgument='<%# Eval("codigo") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/Imagenes/borrar.png" Height="20px" Width="20px"
                        CommandName="Eliminar" CommandArgument='<%# Eval("codigo") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="ID Facultad" DataField="ID_Facultad" />
            <asp:BoundField HeaderText="Codigo" DataField="codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
            <asp:BoundField HeaderText="Fecha de Creacion" DataField="fechaCreacion" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:BoundField HeaderText="Universidad" DataField="nombreUniversidad" />
        </Columns>
    </asp:GridView>

</asp:Content>
