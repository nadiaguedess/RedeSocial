using CamadadeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RedeSocial
{
    public class PostagemBLL
    {
        DAL objDAL = new DAL();

        public int IdUsuario{get; set;}
        public string Titulo { get; set; }
        public string Msg { get; set; }
        public string Link { get; set; }

        public void InserirPostagem()
        {
            objDAL.Conectar();
            string sql = String.Format("insert into conteudo (id_usuario, titulo, msg, data, link) values('{0}','{1}', '{2}', '{3}', '{4}') ",
                                         IdUsuario, Titulo, Msg, DateTime.Now.Date.ToString("yyyy/MM/dd"), Link);
            objDAL.ExecutarComandoSQL(sql);
        }
        public DataTable RetornarTimeLine()
        {
            objDAL.Conectar();
            string sql = "select c.id, p.link_foto, c.titulo, c.msg, link, c.data from conteudo c inner join perfil p " +
                "on c.id_usuario = p.id_usuario where p.id_usuario " +
                "in (select id_usuario2 from relacionamento where id_usuario1 = " + System.Web.HttpContext.Current.Session["id_usuario"].ToString() + ") ";
            return objDAL.RetDataTable(sql);
        }




    }
}