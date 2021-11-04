using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DSI.DAO
{
    class DAO_Exposiciones
    {
        public static List<Exposicion> getExposiciones()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM EXPOSICION";

            DataTable res = db.Query(sql);

            List<Exposicion> exposiciones = new List<Exposicion>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                Exposicion exposicion = new Exposicion();
                exposicion.nombreExpo = res.Rows[i]["Nombre"].ToString();
                exposicion.fechaInicioExpo = Convert.ToDateTime(res.Rows[i]["FechaInicio"]);
                exposicion.fechafinExpo = Convert.ToDateTime(res.Rows[i]["FechaFin"]);
                exposiciones.Add(exposicion);
                exposicion.tipo = new TipoExposicion();
                exposicion.tipo.Nombre = "Temporal";
            }
            return exposiciones;
        }
    }
}
