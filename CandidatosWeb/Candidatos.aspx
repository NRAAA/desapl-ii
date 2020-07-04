<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidatos.aspx.cs" Inherits="CandidatosWeb.Candidatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 536px;
        }
        .auto-style3 {
            width: 536px;
            text-align: center;
        }
        .auto-style4 {
            height: 23px;
            text-align: center;
        }
        .auto-style5 {
            width: 536px;
            height: 23px;
            text-align: center;
        }
        .auto-style6 {
            width: 530px;
        }
        .auto-style7 {
            height: 23px;
            width: 530px;
            text-align: center;
        }
        .auto-style8 {
            width: 530px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">Candidatos</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="Button1" runat="server" Height="31px" Text="Consultar por DNI de alumno" Width="250px" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Button2" runat="server" Height="31px" Text="Consultar por número de teléfono" Width="250px" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="Button3" runat="server" Height="31px" Text="Consultar por correo" Width="250px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button4" runat="server" Height="31px" Text="Consultar por nombre y apellido" Width="250px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
