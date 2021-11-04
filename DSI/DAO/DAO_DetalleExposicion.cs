using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_DetalleExposicion
    {
        public static List<DetalleExposicion> getAsignaciones()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM DETALLEEXPOSICION";

            DataTable res = db.Query(sql);

            List<DetalleExposicion> detalles = new List<DetalleExposicion>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                DetalleExposicion detalle = new DetalleExposicion();
                detalle.lugarAsignado = int.Parse(res.Rows[i]["LugarAsignado"].ToString());
                detalle.exposicion = res.Rows[i]["Exposicion"].ToString();
                detalle.obra = res.Rows[i]["Obra"].ToString();
                detalles.Add(detalle);
            }
            return detalles;
        }
    }
}
