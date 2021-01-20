using CamadadeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RedeSocial
{
    public class ClienteBLL
    {
        DAL objDAL = new DAL();

        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public int id_usuario { get; set; }
        public string estado_civil { get; set; }
        public string link_foto { get; set; }
        public string sexo { get; set; }
        public string profissao { get; set; }
        public string escolaridade { get; set; }
        public string gosto_musical { get; set; }
        public string filme { get; set; }
        public string musica { get; set; }
        public string banda { get; set; }
        public string serie { get; set; }
        public string religiao { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public string cor_olhos { get; set; }
        public string cabelo { get; set; }
        public string hobby { get; set; }
        public string lugar_conhecer { get; set; }
        public string status { get; set; }
        public string time_favorito { get; set; }
        public string esporte { get; set; }
        public string prato_favorito { get; set; }
      
      
      



        public void Registrar()
        {
            objDAL.Conectar();
            string sql = String.Format("insert into USUARIO(nome, data_nascimento, email, senha) values ('{0}', '{1}', '{2}', '{3}')",
                Nome, DataNascimento.ToString("yyyy/MM/dd"), Email, Senha);
            objDAL.ExecutarComandoSQL(sql);
        }



        public bool ValidarLogin(string email, string senha)
        {
            objDAL.Conectar();
            string sql = String.Format("SELECT id, nome FROM USUARIO WHERE EMAIL='{0}' AND SENHA = '{1}'", email, senha);
            DataTable data = objDAL.RetDataTable(sql);


            if (data.Rows.Count == 1)
            {
                System.Web.HttpContext.Current.Session.Add("logado", true);
                System.Web.HttpContext.Current.Session.Add("id_usuario", data.Rows[0]["id"].ToString());
                System.Web.HttpContext.Current.Session.Add("nome_usuario", data.Rows[0]["nome"].ToString());
                return true;
            }
            else
            {
                System.Web.HttpContext.Current.Session.Add("logado", false);
                return false;
            }


        }

        public DataTable CarregarPerfil()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM PERFIL WHERE id_usuario='{0}'", System.Web.HttpContext.Current.Session["id_usuario"].ToString());
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }
        public void InserirPerfil()
        {

            objDAL.Conectar();
            string sql = String.Format("INSERT INTO PERFIL (id_usuario, estado_civil, link_foto, sexo," 
                + "profissao, escolaridade, gosto_musical, filme, musica, banda, serie," 
                + "religiao, peso, altura, cor_olhos, cabelo, hobby, lugar_conhecer, status," 
                + "time_favorito, esporte, prato_favorito) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}')", id_usuario,estado_civil,link_foto,sexo,profissao,escolaridade,gosto_musical,filme,musica,banda,serie,religiao,peso,altura,cor_olhos,cabelo,hobby,lugar_conhecer,status,time_favorito,esporte,prato_favorito);
            objDAL.ExecutarComandoSQL(sql);


        }
        public void AlterarPerfil()
        {
            objDAL.Conectar();
            string sql = String.Format("UPDATE perfil SET  estado_civil = '{0}', link_foto= '{1}', sexo= '{2}',"+
                "profissao= '{3}',escolaridade= '{4}',gosto_musical= '{5}',filme= '{6}',musica= '{7}',banda= '{8}',serie= '{9}',"+
                "religiao= '{10}',peso= '{11}',altura= '{12}',cor_olhos= '{13}',cabelo= '{14}',hobby= '{15}',lugar_conhecer= '{16}',status= '{17}',"+
                "time_favorito= '{18}',esporte= '{19}',prato_favorito= '{20}'  WHERE id_usuario = '{21}'", estado_civil, link_foto, sexo,
                profissao, escolaridade, gosto_musical, filme, musica, banda, serie, religiao, peso, altura, cor_olhos, cabelo,
                hobby, lugar_conhecer, status, time_favorito, esporte, prato_favorito, id_usuario);
            objDAL.ExecutarComandoSQL(sql);
        }

        public DataTable PesquisarUsuarios(string parte_nome)
        {
            objDAL.Conectar();
            string sql = String.Format("select u.id, u.nome, p.estado_civil, p.link_foto from usuario u inner join perfil p " +
                "on u.id = p.id_usuario where u.nome like '{0}%'", parte_nome);
            DataTable data = objDAL.RetDataTable(sql);
            return data;
        }
        public void AdicionarAmigo(string idAmigo, string id_tipo_relacao)
        {
            objDAL.Conectar();
            string sql = String.Format("INSERT relacionamento (id_usuario1, id_usuario2, id_tipo_relacao) " +
                "VALUES({0},{1},{2})", idAmigo, System.Web.HttpContext.Current.Session["id_usuario"].ToString(), id_tipo_relacao);
            objDAL.ExecutarComandoSQL(sql);
        }


    }
}