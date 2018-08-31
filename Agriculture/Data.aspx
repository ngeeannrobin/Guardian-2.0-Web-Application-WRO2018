<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="Agriculture.DataFeed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .right-text{
            text-align:right;
        }
        .center-text{
            text-align:center;
        }
        .right-padding {
            padding-right: 10%;
        }
        table, td, th {
            border: 1px solid black;
            padding: 0px;
            border-collapse: collapse;
        }
        .quarter{
            width: 25%;
        }
        .parent-size{
            width:100%;
        }
    
        .auto-style2 {
            text-align: center;
        }
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph" runat="server">
                <table class="parent-size">
                    <tr>
                        <td class="center-text quarter"></td>
                        <td class="center-text quarter"><strong>Current</strong></td>
                        <td class="center-text quarter"><strong>Average</strong></td>
                        <td class="center-text quarter"><strong>Deviation</strong></td>
                    </tr>
                    <tr>
                        <td class="right-text right-padding quarter">
                            <strong>Humidity</strong>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblHumiC" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblHumiA" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblHumiD" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="right-text right-padding quarter">
                            <strong>Pressure</strong>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblPresC" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblPresA" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblPresD" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="right-text right-padding quarter">
                            <strong>Temperature</strong>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblTempC" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblTempA" runat="server"></asp:Label>
                        </td>
                        <td class="center-text quarter">
                            <asp:Label ID="lblTempD" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
</asp:Content>
