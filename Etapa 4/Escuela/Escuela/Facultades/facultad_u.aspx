<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_u.aspx.cs" Inherits="Escuela.Facultades.facultad_u" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
         <tr>
            <td>ID: </td>
            <td>
                <asp:Label ID="lblIdFacultad" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>Codigo: </td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" ValidationGroup="vlg1" />
            </td>
        </tr>
    </table>

</asp:Content>
