<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Action.aspx.cs" Inherits="Agriculture.Action" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph" runat="server">
    <center>
        <asp:Label ID="lblMessage" runat="server" Text="Label" Font-Size="XX-Large"></asp:Label>
        <br />
        <asp:Button ID="btnStart" runat="server" Text="Start" OnClick="btnStart_Click" Font-Bold="True" Font-Size="XX-Large" Height="100px" Width="49%" />
        <asp:Button ID="btnStop" runat="server" Text="Stop" OnClick="btnStop_Click" Font-Bold="True" Font-Size="XX-Large" Height="100px" Width="49%" />
        <br />
    </center>

</asp:Content>
