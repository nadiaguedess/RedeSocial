using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RedeSocial;

namespace RedeSocial
{
    public partial class registrar : System.Web.UI.Page
    {
        ClienteBLL objCliente = new ClienteBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            objCliente.Nome = txtnome.Text;
            objCliente.DataNascimento = DateTime.Parse(txtdata.Text);
            objCliente.Email = txtemail.Text;
            objCliente.Senha = txtsenha.Text;

            objCliente.Registrar();

            Response.Write("<script>alert('Registro realizado com sucesso!');</script>");


        }
    }
}