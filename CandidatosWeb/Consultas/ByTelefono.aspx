<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ByTelefono.aspx.cs" Inherits="CandidatosWeb.Consultas.ByTelefobo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 257px;
        }
        .auto-style3 {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Ingresar número de celular:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbTel" runat="server" MaxLength="9" Width="168px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:GridView ID="gvAlumno" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="DniAlumno" HeaderText="DNI" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombre" />
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="EmailAlumno" HeaderText="Email" />
                <asp:BoundField DataField="TelAlumno" HeaderText="Teléfono" />
                <asp:BoundField DataField="PromGlobal" HeaderText="Promedio Global" />
                <asp:BoundField DataField="FecInscrip" HeaderText="Fecha de Inscripción" />
                <asp:BoundField DataField="UbiAlumno" HeaderText="Zip" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
