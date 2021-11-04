using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_Sede
    {
        public static List<Sede> getSede()
        {
           
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM SEDE";

            DataTable res = db.Query(sql);

            List<Sede> sedes = new List<Sede>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                Sede sede = new Sede();
                sede.Nombre = res.Rows[i]["Nombre"].ToString();
                sede.CantMaximaVisitantes = int.Parse(res.Rows[i]["CantMaximaVisitantes"].ToString());
                sede.CantMaxPorGuia = int.Parse(res.Rows[i]["CantMaximaPorGuia"].ToString());
                sedes.Add(sede);
            }
            return sedes;
        }
    }
}
