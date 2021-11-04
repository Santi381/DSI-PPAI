using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Entidades
{
    class TipoExposicion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool esTemporal()
        {
            bool res = false;
            if (this.Nombre == "Temporal")
            {
                res = true;
            }
            return res;
        }
    }
}
