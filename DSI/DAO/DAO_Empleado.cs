using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DSI.DAO
{
    class DAO_Empleado
    {
        public static List<Empleado> getEmpleado()
        {

            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM EMPLEADO";

            DataTable res = db.Query(sql);

            List<Empleado> guias = new List<Empleado>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                Empleado guia = new Empleado();
                guia.nombre = res.Rows[i]["Nombre"].ToString();
                guia.apellido = res.Rows[i]["Apellido"].ToString();
                guia.cuit = res.Rows[i]["CUIT"].ToString();
                guia.dni = res.Rows[i]["DNI"].ToString();
                guia.domicilio = res.Rows[i]["Domicilio"].ToString();
                guia.fechaIngreso = DateTime.Parse(res.Rows[i]["FechaIngreso"].ToString());
                guia.fechaNacimiento = DateTime.Parse(res.Rows[i]["FechaNacimiento"].ToString());
                guia.mail = res.Rows[i]["Email"].ToString();
                guia.sexo = res.Rows[i]["Sexo"].ToString();
                guia.telefono = res.Rows[i]["Telefono"].ToString();
                guia.cargo = new Cargo();
                guia.cargo.nombre = "Guia";
                guia.horario = new HorarioEmpleado();
                guia.horario.gethoraIngreso = 7;
                guia.horario.gethoraSalida = 19;
                guias.Add(guia);
            }
            return guias;
        }
    }
}
