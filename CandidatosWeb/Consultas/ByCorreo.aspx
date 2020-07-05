<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ByCorreo.aspx.cs" Inherits="CandidatosWeb.Consultas.ByCorreo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Ingresa un correo:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbCorreo" runat="server" Width="375px" TextMode="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnCorreo" runat="server" OnClick="btnCorreo_Click" Text="Consultar" />
                </td>
            </tr>
        </table>
        <br />
    </p>
    <p class="center">
        <asp:GridView ID="gvAlumno" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="DniAlumno" HeaderText="DNI" />
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombre" />
                <asp:BoundField DataField="EmailAlumno" HeaderText="Email" />
                <asp:BoundField DataField="TelAlumno" HeaderText="Teléfono" />
                <asp:BoundField DataField="PromGlobal" HeaderText="Promedio global" />
                <asp:BoundField DataField="FecInscrip" HeaderText="Fecha de Inscripción" />
                <asp:BoundField DataField="UbiAlumno" HeaderText="Zip" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
