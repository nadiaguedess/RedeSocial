<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="RedeSocial.registrar" %>
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
    
    
    <div style="float:left; width: 100%; padding-left:40%; height: 703px;">
   
       <asp:Panel ID="Panel1" runat="server" BackColor="#cece" CssClass="form-control" Height="581px" Width="414px">  
          <h1>Registro de Usuário</h1><br />
            <asp:Label ID="lblnome" runat="server" Text="Nome:"></asp:Label>
    <br />
    <asp:TextBox ID="txtnome" runat="server" CssClass="form-control" Width="304px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbldata" runat="server" Text="Data de Nascimento:"></asp:Label>
    <br />
    <asp:TextBox ID="txtdata" runat="server" CssClass="form-control" Width="182px" TextMode="Date"></asp:TextBox>
    <br />
    <br />
           <asp:Label ID="lblemail" runat="server" Text="Email:"></asp:Label>
    <br />
    <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="254px"></asp:TextBox>
    <br />
    <br />
           <asp:Label ID="lblsenha" runat="server" Text="Senha:"></asp:Label>
    <br />
    <asp:TextBox ID="txtsenha" runat="server" CssClass="form-control" Width="154px" TextMode="Password"></asp:TextBox>
    <br />
    <br />
     <asp:Button ID="btnregistrar" runat="server" Text="Entrar" CssClass="btn alert-danger btn-success" OnClick="btnregistrar_Click" />
    <br />
       </asp:Panel>
       </div>

</asp:Content>