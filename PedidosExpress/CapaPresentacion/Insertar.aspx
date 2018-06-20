<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="CapaPresentacion.PlatosPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 82px;
        }
        .auto-style4 {
            width: 222px;
        }
        .auto-style5 {
            height: 23px;
            width: 222px;
        }
        .auto-style6 {
            height: 82px;
            width: 222px;
        }
        .auto-style7 {
            height: 69px;
            width: 222px;
        }
        .auto-style8 {
            height: 69px;
        }
        .auto-style10 {
            height: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">Descripcion&nbsp; :</td>
            <td>
                <asp:TextBox ID="TBDescripcion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Precio: </td>
            <td>
                <asp:TextBox ID="TBPrecio" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Fotografia: </td>
            <td class="auto-style2">
                <asp:FileUpload ID="FUFotografia" runat="server" />
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style7">Disponible:</td>
            <td class="auto-style8">
                <asp:RadioButtonList ID="RBDisponible" runat="server">
                    <asp:ListItem Value="0">NO</asp:ListItem>
                    <asp:ListItem Value="1">SI</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style10">Nombre:</td>
            <td class="auto-style10">
                <asp:TextBox ID="TBnombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="BInsertar" runat="server" OnClick="BInsertar_Click" Text="Insertar" />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
    </table>
</asp:Content>
