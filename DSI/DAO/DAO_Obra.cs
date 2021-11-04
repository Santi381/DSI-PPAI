using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_Obra
    {
        public static List<Obra> getObras()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM OBRA";

            DataTable res = db.Query(sql);

            List<Obra> obras = new List<Obra>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                Obra obra = new Obra();
                obra.Nombre = res.Rows[i]["Nombre"].ToString();
                obra.Alto = int.Parse(res.Rows[i]["Alto"].ToString());
                obra.Ancho = int.Parse(res.Rows[i]["Ancho"].ToString());
                obra.CodigoSensor = int.Parse(res.Rows[i]["CodigoSensor"].ToString());
                obra.DuracionExtendida = int.Parse(res.Rows[i]["DuracionExtendida"].ToString());
                obra.DuracionResumida = int.Parse(res.Rows[i]["DuracionResumida"].ToString());
                obra.FechaCreacion = DateTime.Parse(res.Rows[i]["FechaCreacion"].ToString());
                obra.FechaPrimerIngreso = DateTime.Parse(res.Rows[i]["FechaPrimerIngreso"].ToString());
                obra.Peso = int.Parse(res.Rows[i]["Peso"].ToString());
                obra.Valuacion = int.Parse(res.Rows[i]["Valuacion"].ToString());
                obras.Add(obra);
            }
            return obras;
        }
    }
}
