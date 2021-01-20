<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adicionar_amigo.aspx.cs" Inherits="RedeSocial.adicionar_amigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
</asp:Panel>
<h1>
    Adicionando Amigos... ;-)</h1>
   
<label>
    Informe o tipo de relacionamento com esse usuário<br />
<br />
    </label>
&nbsp;<p>
    <asp:DropDownList ID="cbmTipoRelacionamento" runat="server" OnSelectedIndexChanged="cbmTipoRelacionamento_SelectedIndexChanged">
        <asp:ListItem>Amizade</asp:ListItem>
        <asp:ListItem>Namoro</asp:ListItem>
        <asp:ListItem>Família</asp:ListItem>
        <asp:ListItem>Trabalho</asp:ListItem>
    </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Add Amigo" OnClick="Button1_Click" />
    </p>
</asp:Content>
