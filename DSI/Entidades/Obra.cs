using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Entidades
{
    class Obra
    {
        public string Nombre { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int CodigoSensor { get; set; }
        public int DuracionExtendida { get; set; }
        public int DuracionResumida { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPrimerIngreso { get; set; }
        public int Peso { get; set; }
        public int Valuacion { get; set; }
    }
}
