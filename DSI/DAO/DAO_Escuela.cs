using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DSI.DAO
{
    class DAO_Escuela
    {
        public static List<Escuela> getEscuelas()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM ESCUELA";

            DataTable res = db.Query(sql);

            List<Escuela> escuelas = new List<Escuela>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                Escuela escuela = new Escuela();
                escuela.Direccion = res.Rows[i]["Direccion"].ToString();
                escuela.Email = res.Rows[i]["Email"].ToString();
                escuela.Nombre = res.Rows[i]["Nombre"].ToString();
                escuela.TeleCelular = res.Rows[i]["TeleCelular"].ToString();
                escuela.TeleFijo = res.Rows[i]["TeleFijo"].ToString();
                escuelas.Add(escuela);
            }
            return escuelas;
        }
    }
}
