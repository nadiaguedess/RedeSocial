<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RedeSocial.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <%
        try
        {
            if (bool.Parse(Request.QueryString["logout"].ToString()))
            {
                Session.Clear();
                Session.Abandon();
                Response.Redirect("index.aspx");
            }
        }
        catch 
        { }
        
        
         %>
    
    
    <div style="float:left; width: 100%; padding-left:40%;">
   
       <asp:Panel ID="Panel1" runat="server" BackColor="#cece" CssClass="form-control" Height="340px" Width="269px">  
          <h1>Autenticação</h1><br />
            <asp:Label ID="lblemail" runat="server" Text="Email:"></asp:Label>
    <br />
    <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="240px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblsenha" runat="server" Text="Senha:"></asp:Label>
    <br />
    <asp:TextBox ID="txtsenha" runat="server" TextMode="Password" CssClass="form-control" Width="240px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnentrar" runat="server" Text="Entrar" CssClass="btn alert-danger btn-success" OnClick="btnentrar_Click" />
    <br />
       </asp:Panel>
       </div>

</asp:Content>
