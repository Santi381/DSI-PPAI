using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_TipoVisita
    {
        public static List<TipoVisita> getTipoVisita()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM TIPOVISITA";

            DataTable res = db.Query(sql);

            List<TipoVisita> tiposVisitas = new List<TipoVisita>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                TipoVisita tipoVisita = new TipoVisita();
                tipoVisita.mostrarNombre = res.Rows[i]["Nombre"].ToString();
                tiposVisitas.Add(tipoVisita);
            }
            return tiposVisitas;
        }
    }
}
