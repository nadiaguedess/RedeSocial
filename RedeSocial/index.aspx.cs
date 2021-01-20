using RedeSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedeSocial
{
    public partial class index : System.Web.UI.Page
    {
        ClienteBLL objCliente = new ClienteBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click(object sender, EventArgs e)
        {
            if (objCliente.ValidarLogin(txtemail.Text, txtsenha.Text))
            {
                Response.Redirect("time_line.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuário ou senha inválidos!');</script>");
            }
        }
    }
}