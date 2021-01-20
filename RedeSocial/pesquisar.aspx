<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pesquisar.aspx.cs" Inherits="RedeSocial.pesquisar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%
    string pesquisa = "";
    try
    { pesquisa = Request.Form["txtPesquisa"].ToString(); } catch  {  }

    if(String.IsNullOrEmpty(pesquisa) == false)
    {
        RedeSocial.ClienteBLL objCliente = new RedeSocial.ClienteBLL();
        System.Data.DataTable dados = objCliente.PesquisarUsuarios(pesquisa);
    
    if (dados.Rows.Count > 0)
    {
        Response.Write("<table class='table'><thead class='thead-inverse'><tr><th>#</th>" +
            "<th>Foto</th>" +
            "<th>Nome</th>" +
            "<th>Estado Civil</th>" +
            "<th>Add Amigo</th>" +
            "</tr>" +
            "</thead>" +
            "<tbody>");
        
        for(int i = 0; i < dados.Rows.Count; i++)
        {
            Response.Write("<form method='POST' action='adicionar_amigo.aspx' name='formAddAmigo_" + dados.Rows[i]["id"].ToString() + "'>");
            Response.Write("<input id='txtIDAmigo' name='txtIDAmigo' type='hidden' value='" + dados.Rows[i]["id"].ToString() + "' />" );
            
            Response.Write("<tr><th scope='row'>" + dados.Rows[i]["id"].ToString() + "</th><td>" +
                "<img alt='' src='" + dados.Rows[i]["link_foto"].ToString() + "' class='img-circle' height='100' width='100'/></td>" +
                "<td>" + dados.Rows[i]["nome"].ToString() + "</td> " +
                 "<td>" + dados.Rows[i]["estado_civil"].ToString() + "</td> " +
                 "<td><a href='adicionar_amigo.aspx?idamigo=" + dados.Rows[i]["id"].ToString() + "'>Add Amigo</a></td></tr>");
                // "<td><input id='btnSubmit' type='submit' value='Add Amigo' /></td></tr>");
            Response.Write("</form>");           
                
        }
        Response.Write("</tbody></table>");
        
        
    }
    else{
        Response.Write("<script>alert('Nenhum resultado encontrado!');</script>");
    }
   
    }
    
    
    
    
     %>










</asp:Content>
