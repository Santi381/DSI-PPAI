using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_AsignacionesVisita
    {
        public static List<AsignacionVisita> getAsignaciones()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM ASIGNACIONVISTA";

            DataTable res = db.Query(sql);

            List<AsignacionVisita> asignaciones = new List<AsignacionVisita>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                AsignacionVisita asignacion = new AsignacionVisita();
                asignacion.fechaHoraInicio = DateTime.Parse(res.Rows[i]["FechaHoraInicio"].ToString());
                asignacion.fechaHoraFin = DateTime.Parse(res.Rows[i]["FechaHoraFin"].ToString());
                asignacion.empleado = res.Rows[i]["Empleado"].ToString();
                asignacion.nroReserva = int.Parse(res.Rows[i]["NroReserva"].ToString());
                asignaciones.Add(asignacion);
            }
            return asignaciones;
        }
    }
}
