<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="time_line.aspx.cs" Inherits="RedeSocial.time_line" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%
        try
        {
            if(!bool.Parse(Session["logado"].ToString()))
            {
                Response.Redirect("index.aspx");
            }
        }
        catch 
        {

            Response.Redirect("index.aspx");
        }
        
        
         %>







    <asp:Panel ID="Panel1" runat="server">
        <label>Título:</label>   
        <asp:TextBox ID="txttitulo" runat="server"></asp:TextBox>
        <br />
        <br />
        <label>Mensagem:</label>   
        <asp:TextBox ID="txtmsg" runat="server"></asp:TextBox>
        <br />
        <br />
        <label>Link:</label>   
        <asp:TextBox ID="txtlink" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnpostar" runat="server" Text="Postar" OnClick="Button1_Click" />
        <br />
        <br />


    </asp:Panel>







</asp:Content>
