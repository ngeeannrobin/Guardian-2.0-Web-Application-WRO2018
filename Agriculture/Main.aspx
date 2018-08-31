<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Agriculture.Main" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
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
    
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph" runat="server">
    <center>
        <asp:Image ID="imgMain" runat="server" ImageUrl="images/main.jpg" Width="50%" ImageAlign="Middle"/>
    </center>
</asp:Content>
