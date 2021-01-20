using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedeSocial
{
    public partial class time_line : System.Web.UI.Page
    {
        PostagemBLL objPostagem = new PostagemBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ImprimirTimeLine();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objPostagem.IdUsuario = int.Parse(Session["id_usuario"].ToString());
            objPostagem.Titulo = txttitulo.Text;
            objPostagem.Msg = txtmsg.Text;
            objPostagem.Link = txtlink.Text;
            objPostagem.InserirPostagem();

            txttitulo.Text = "";
            txtlink.Text = "";
            txtmsg.Text = "";

            Response.Write("<script>alert('Postagem realizada!')</script>");
        }
        private void ImprimirTimeLine()
        {
            PostagemBLL objPostagem = new PostagemBLL();
            DataTable dados = objPostagem.RetornarTimeLine();
            if (dados.Rows.Count > 0)
            {
                Response.Write("<table class='table'><thead class='thead-inverse'><tr><th>#</th>" +
                    "<th>Foto</th>" +
                    "<th>Título</th>" +
                    "<th>Mensagem</th>" +
                    "<th>Link</th>" +
                    "</tr>"+
                    "</thead>"+
                    "<tbody>" );

                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    Response.Write("<tr><th scope ='row'>" + dados.Rows[i]["id"].ToString() + "</th><td>" +
                       "<img alt='' src'" + dados.Rows[i]["link_foto"].ToString() + "' class='img-circle height='100' width='100' /></td>"+
                       "<td>" + dados.Rows[i]["titulo"].ToString() +"</td>"+
                       "<td>" + dados.Rows[i]["msg"].ToString() +"</td>"+
                        "<td><a href='" + dados.Rows[i]["link"].ToString() +"'>"+ dados.Rows[i]["link"].ToString() + "</a></td></tr>");
                       
                }
                Response.Write("</tbody></table>");

            }
        }

        
    }
}