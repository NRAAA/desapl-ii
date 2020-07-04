<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="HistorialAcademico.aspx.cs" Inherits="CandidatosWeb.Historial.Historial_académico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 361px;
        }
        .auto-style3 {
            width: 254px;
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Ingresa número de documento a consultar:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbDNI" runat="server" Width="236px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="gvAlumno" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvPromedioCurso" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvPorcInas" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvNotas" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
