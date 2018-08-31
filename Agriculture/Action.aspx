<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Action.aspx.cs" Inherits="Agriculture.Action" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph" runat="server">
    <center>
        <asp:Button ID="btnTest" runat="server" Text="Turn" OnClick="btnTest_Click" />
        <asp:Button ID="btnTest2" runat="server" Text="Stop" OnClick="btnTest2_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        <br />
    </center>

</asp:Content>
