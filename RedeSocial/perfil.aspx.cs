using RedeSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace RedeSocial
{
    public partial class perfil : System.Web.UI.Page
    {

        ClienteBLL objCliente = new ClienteBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CarregarPerfil();
            }
            
        }
        private void CarregarPerfil()
        {

            DataTable data = objCliente.CarregarPerfil();

            if (data.Rows.Count != 0)
            {
                txtID.Text = data.Rows[0]["id"].ToString();

                Image1.ImageUrl = data.Rows[0]["link_foto"].ToString();
                txtstatus.Text = data.Rows[0]["status"].ToString();
                dropestado_civil.Text = data.Rows[0]["estado_civil"].ToString();
                urlfoto.Text = data.Rows[0]["link_foto"].ToString();

                if (data.Rows[0]["sexo"].ToString() == "M")
                {
                    Masculino.Checked = true;
                }
                else
                {
                    Feminino.Checked = true;
                }

                txtprofissao.Text = data.Rows[0]["profissao"].ToString();
                dropescolaridade.Text = data.Rows[0]["escolaridade"].ToString();
                dropgostomusical.Text = data.Rows[0]["gosto_musical"].ToString();
                txtfilme.Text = data.Rows[0]["filme"].ToString();
                txtmusica.Text = data.Rows[0]["musica"].ToString();
                txtbanda.Text = data.Rows[0]["banda"].ToString();
                txtserie.Text = data.Rows[0]["serie"].ToString();
                txtreligiao.Text = data.Rows[0]["religiao"].ToString();
                txtpeso.Text = data.Rows[0]["peso"].ToString();
                txtaltura.Text = data.Rows[0]["altura"].ToString();
                dropcorolhos.Text = data.Rows[0]["cor_olhos"].ToString();
                dropcabelo.Text = data.Rows[0]["cabelo"].ToString();
                txthobby.Text = data.Rows[0]["hobby"].ToString();
                txtlugar.Text = data.Rows[0]["lugar_conhecer"].ToString();
                txttime.Text = data.Rows[0]["time_favorito"].ToString();
                txtesporte.Text = data.Rows[0]["esporte"].ToString();
                txtprato.Text = data.Rows[0]["prato_favorito"].ToString();
            }
            else
            {
                Response.Write("<script>alert('O usuário não possui um perfil ainda!');</script>");
                
            }

        }


        protected void btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                objCliente.id_usuario = int.Parse(Session["id_usuario"].ToString());
                objCliente.estado_civil = dropestado_civil.Text;
                objCliente.link_foto = urlfoto.Text;
                if (Masculino.Checked)
                {
                    objCliente.sexo = "M";

                }
                else
                {
                    objCliente.sexo = "F";
                }

                objCliente.profissao = txtprofissao.Text;
                objCliente.escolaridade = dropescolaridade.Text;
                objCliente.gosto_musical = dropgostomusical.Text;
                objCliente.filme = txtfilme.Text;
                objCliente.musica = txtmusica.Text;
                objCliente.banda = txtbanda.Text;
                objCliente.serie = txtserie.Text;
                objCliente.religiao = txtreligiao.Text;
                objCliente.peso = txtpeso.Text;
                objCliente.altura = txtaltura.Text;
                objCliente.cor_olhos = dropcorolhos.Text;
                objCliente.cabelo = dropcabelo.Text;
                objCliente.hobby = txthobby.Text;
                objCliente.lugar_conhecer = txtlugar.Text;
                objCliente.status = txtstatus.Text;
                objCliente.time_favorito = txttime.Text;
                objCliente.esporte = txtesporte.Text;
                objCliente.prato_favorito = txtprato.Text;

                objCliente.InserirPerfil();
                objCliente.CarregarPerfil();



            }


            else
            {


                objCliente.id_usuario = int.Parse(Session["id_usuario"].ToString());
                objCliente.estado_civil = dropestado_civil.Text;
                objCliente.link_foto = urlfoto.Text;
                if (Masculino.Checked)
                {
                    objCliente.sexo = "M";

                }
                else
                {
                    objCliente.sexo = "F";
                }

                objCliente.profissao = txtprofissao.Text;
                objCliente.escolaridade = dropescolaridade.Text;
                objCliente.gosto_musical = dropgostomusical.Text;
                objCliente.filme = txtfilme.Text;
                objCliente.musica = txtmusica.Text;
                objCliente.banda = txtbanda.Text;
                objCliente.serie = txtserie.Text;
                objCliente.religiao = txtreligiao.Text;
                objCliente.peso = txtpeso.Text;
                objCliente.altura = txtaltura.Text;
                objCliente.cor_olhos = dropcorolhos.Text;
                objCliente.cabelo = dropcabelo.Text;
                objCliente.hobby = txthobby.Text;
                objCliente.lugar_conhecer = txtlugar.Text;
                objCliente.status = txtstatus.Text;
                objCliente.time_favorito = txttime.Text;
                objCliente.esporte = txtesporte.Text;
                objCliente.prato_favorito = txtprato.Text;



                objCliente.AlterarPerfil();



                Response.Write("<script>alert('Perfil alterado com sucesso!');</script>");
                objCliente.CarregarPerfil();

            }




        }
    }
}