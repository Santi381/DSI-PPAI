using DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DAO_Sesion
    {
        public static Sesion getSesion()
        {
            Sesion actual = new Sesion();
            actual.fechaHoraInicio = DateTime.Now;
            actual.usuario = new Usuario();
            actual.usuario.caducidad = (DateTime.Now);
            actual.usuario.nombre = "Pedro";
            actual.usuario.pwd = "1234";

            return actual;
        }
    }
}
