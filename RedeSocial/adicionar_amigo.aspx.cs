using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedeSocial
{
    public partial class adicionar_amigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarTiposRelacionamento();
            }
        }
        private void CarregarTiposRelacionamento()
        {
            TipoRelacionamentoBLL objTipo = new TipoRelacionamentoBLL();
            cbmTipoRelacionamento.DataSource = objTipo.ListarTiposRelacionamento();
            cbmTipoRelacionamento.DataTextField = "descricao";
            cbmTipoRelacionamento.DataValueField = "id";
            cbmTipoRelacionamento.DataBind();
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL objCliente = new ClienteBLL();
                string idAmigo = Request.QueryString["idamigo"].ToString();
                objCliente.AdicionarAmigo(idAmigo, cbmTipoRelacionamento.SelectedValue.ToString());
                Response.Write("<script>alert('Você tem mais amigos!');</script>");

            }
            catch
            {
                Response.Write("<script>('Vocês já possuem algum tipo de relacionamento');</script>");
            }
            
        }

        protected void cbmTipoRelacionamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}