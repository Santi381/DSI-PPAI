using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DSI.DAO
{
    class DAO_Reserva
    {
        public static List<ReservaVisita> getReservas()
        {
            DB_Connection db = new DB_Connection();
            string sql = "SELECT * FROM RESERVAVISITA";

            DataTable res = db.Query(sql);

            List<ReservaVisita> reservas = new List<ReservaVisita>();

            for (int i = 0; i < res.Rows.Count; i++)
            {
                ReservaVisita reserva = new ReservaVisita();
                reserva.cantidadAlumnos = int.Parse(res.Rows[i]["CantidadAlumnos"].ToString());
                reserva.cantidadAlumnosConfirmada = int.Parse(res.Rows[i]["CantidadAlumnosConfirmada"].ToString());
                reserva.duracionEstimada = int.Parse(res.Rows[i]["DuracionEstimada"].ToString());
                reserva.fechaHoraCreacion = DateTime.Parse(res.Rows[i]["FechaHoraCreacion"].ToString());
                reserva.fechaHoraReserva = DateTime.Parse(res.Rows[i]["FechaHoraReserva"].ToString());
                reserva.horaFinReal = int.Parse(res.Rows[i]["HoraFinReal"].ToString());
                reserva.horaInicioReal = int.Parse(res.Rows[i]["HoraInicioReal"].ToString());
                reserva.nroReserva = int.Parse(res.Rows[i]["NumeroReserva"].ToString());
            }
            return reservas;
        }

        public static int nroReservas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection canalConexion = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand command = new SqlCommand();
                string query = "SELECT MAX(NumeroReserva) FROM RESERVAVISITA";

                command.Parameters.Clear();
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                canalConexion.Open();
                command.Connection = canalConexion;
                try
                {
                    int result = (int)command.ExecuteScalar();
                    return result;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                canalConexion.Close();
            }
        }
    }
}
