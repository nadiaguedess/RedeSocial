using CamadadeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RedeSocial
{
    public class TipoRelacionamentoBLL
    {
        DAL objDAL = new DAL();

        public DataTable ListarTiposRelacionamento()
        {
            objDAL.Conectar();
            string sql = "SELECT * FROM tipo_relacionamento";
            DataTable data = objDAL.RetDataTable(sql);
            return data;
        }
    }
}