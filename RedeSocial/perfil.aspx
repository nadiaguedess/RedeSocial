<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="RedeSocial.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div style="float:left; width: 70%; padding-left:30%; height: 999px;">
    <asp:Panel ID="Panel1" runat="server" BackColor="#cece" CssClass="form-control" Width="430px">
        <br />
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Meu perfil</h1>
        <asp:TextBox ID="txtID" runat="server" Visible="False"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="191px" Width="224px" />
        <br />
        <br />
        Status:
        <asp:TextBox ID="txtstatus" runat="server" Height="96px" TextMode="MultiLine" Width="285px"></asp:TextBox>
        <br />
        Estado Civil:<asp:DropDownList ID="dropestado_civil" runat="server">
            <asp:ListItem>Casado</asp:ListItem>
            <asp:ListItem>Solteiro</asp:ListItem>
            <asp:ListItem>Namorando</asp:ListItem>
            <asp:ListItem>Viúvo </asp:ListItem>
            <asp:ListItem>Divorciado</asp:ListItem>
        </asp:DropDownList>
        <br />
        URL Foto<asp:TextBox ID="urlfoto" runat="server"></asp:TextBox>
        <br />
        Sexo:<asp:RadioButton ID="Masculino" runat="server" Text="Masculino" GroupName="sexo" />
        <asp:RadioButton ID="Feminino" runat="server" Text="Feminino" GroupName="sexo" />
        <br />
        <asp:Label ID="lblprofissao" runat="server" Text="Profissão:"></asp:Label>
        <asp:TextBox ID="txtprofissao" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblescolaridade" runat="server" Text="Escolaridade:"></asp:Label>
        <asp:DropDownList ID="dropescolaridade" runat="server">
            <asp:ListItem>Ensino Médio </asp:ListItem>
            <asp:ListItem>Ensino Superior</asp:ListItem>
            <asp:ListItem>Mestrado</asp:ListItem>
            <asp:ListItem>Doutorado</asp:ListItem>
            <asp:ListItem>PHD</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblgostomusical" runat="server" Text="Gosto Musical"></asp:Label>
        <asp:DropDownList ID="dropgostomusical" runat="server">
            <asp:ListItem>Rock</asp:ListItem>
            <asp:ListItem>Pop</asp:ListItem>
            <asp:ListItem>Samba</asp:ListItem>
            <asp:ListItem>Pagode</asp:ListItem>
            <asp:ListItem>Rap</asp:ListItem>
            <asp:ListItem>Raggae</asp:ListItem>
            <asp:ListItem>Indie</asp:ListItem>
            <asp:ListItem>Metal</asp:ListItem>
            <asp:ListItem>Funk</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblfilme" runat="server" Text="Filme:"></asp:Label>
        <asp:TextBox ID="txtfilme" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblmusica" runat="server" Text="Música:"></asp:Label>
        <asp:TextBox ID="txtmusica" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblbanda" runat="server" Text="Banda:"></asp:Label>
        <asp:TextBox ID="txtbanda" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblserie" runat="server" Text="Série TV:"></asp:Label>
        <asp:TextBox ID="txtserie" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblreligiao" runat="server" Text="Religião"></asp:Label>
        <asp:TextBox ID="txtreligiao" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblpeso" runat="server" Text="Peso:"></asp:Label>
        <asp:TextBox ID="txtpeso" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblaltura" runat="server" Text="Altura:"></asp:Label>
        <asp:TextBox ID="txtaltura" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblcorolhos" runat="server" Text="Cor dos Olhos:"></asp:Label>
        <asp:DropDownList ID="dropcorolhos" runat="server">
            <asp:ListItem>Pretos</asp:ListItem>
            <asp:ListItem>Castanhos</asp:ListItem>
            <asp:ListItem>Verdes</asp:ListItem>
            <asp:ListItem>Azuis</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblcabelo" runat="server" Text="Cor dos Cabelos:"></asp:Label>
        <asp:DropDownList ID="dropcabelo" runat="server">
            <asp:ListItem>Pretos</asp:ListItem>
            <asp:ListItem>Castanhos</asp:ListItem>
            <asp:ListItem>Loiros</asp:ListItem>
            <asp:ListItem>Ruivos</asp:ListItem>
            <asp:ListItem>Colorido</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblhobby" runat="server" Text="Hobby:"></asp:Label>
        <asp:TextBox ID="txthobby" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbllugar" runat="server" Text="Lugar que deseja conhecer:"></asp:Label>
        <asp:TextBox ID="txtlugar" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbltime" runat="server" Text="Time Favorito:"></asp:Label>
        <asp:TextBox ID="txttime" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblesporte" runat="server" Text="Esporte:"></asp:Label>
        <asp:TextBox ID="txtesporte" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblprato" runat="server" Text="Prato Favorito:"></asp:Label>
        <asp:TextBox ID="txtprato" runat="server"></asp:TextBox>
        <br />
         <asp:Button ID="btnsalvar" runat="server" Text="Salvar" CssClass="btn btn-success" OnClick="btnsalvar_Click" />
        <br />
    </asp:Panel>
        </div>
</asp:Content>
