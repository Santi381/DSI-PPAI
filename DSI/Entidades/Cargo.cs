using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Entidades
{
    class Cargo
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public bool esGuia()
        {
            bool res = false;
            if (this.nombre == "Guia")
            {
                res = true;
            }
            return res;
        }
    }
}
