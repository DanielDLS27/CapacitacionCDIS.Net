<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_i.aspx.cs" Inherits="Escuela.Facultades.facultad_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
         <tr>
            <td>Codigo: </td>
            <td>
                <asp:TextBox ID="txtCodigo" MaxLength="6" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_codigo" runat="server" ControlToValidate="txtCodigo"
                    ErrorMessage="El codigo es requerido" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_codigo" runat="server" ControlToValidate="txtCodigo"
                     ValidationExpression="[A-Z][A-Z][A-Z][A-Z][0-9][0-9]" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="Solo se acepta con el formato 4 letras mayusculas seguido de dos numeros"></asp:RegularExpressionValidator>
            </td>
        </tr>
         <tr>
            <td>Nombre: </td>
            <td>
                <asp:TextBox ID="txtNombre" MaxLength="100" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_nombre" runat="server" ControlToValidate="txtNombre"
                    ErrorMessage="El nombre es requerido" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Fecha de Creacion: </td>
            <td>
                <asp:TextBox ID="txtFechaCreacion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_fechaCreacion" runat="server" ControlToValidate="txtFechaCreacion"
                    ErrorMessage="La fecha de creacion es requerida" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cv_fecha" runat="server" ControlToValidate="txtFechaCreacion"
                     Type="Date" Operator="DataTypeCheck" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="El formato es incorrecto (dd/mm/yyyy)"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Universidad: </td>
            <td>
                <asp:DropDownList ID="ddlUniversidad" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfv_universidad" runat="server" ControlToValidate="ddlUniversidad"
                    ErrorMessage="La universidad es requerida" InitialValue="0" Display="Dynamic" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" ValidationGroup="vlg1" />
            </td>
        </tr>
    </table>

    <asp:GridView ID="grd_facultades" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Codigo" DataField="codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
        </Columns>
    </asp:GridView>

</asp:Content>
