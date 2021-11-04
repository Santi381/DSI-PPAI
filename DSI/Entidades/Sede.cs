using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Entidades
{
    class Sede
    {
        int cantMaximaVisitantes;
        int cantMaxPorGuia;
        string nombre;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int CantMaximaVisitantes
        {
            get => cantMaximaVisitantes;
            set => cantMaximaVisitantes = value;
        }

        public int CantMaxPorGuia
        {
            get => cantMaxPorGuia;
            set => cantMaxPorGuia = value;
        }
    }
}
