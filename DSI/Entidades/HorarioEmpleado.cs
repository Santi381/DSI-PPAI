using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Entidades
{
    class HorarioEmpleado
    {
        int horaIngreso;
        int horaSalida;

        public int gethoraIngreso
        {
            get => horaIngreso;
            set => horaIngreso = value;
        }

        public int gethoraSalida
        {
            get => horaSalida;
            set => horaSalida = value;
        }

        public bool dispEnFechaHoraReserva(DateTime fecha)
        {
            bool disp = false;
            if (fecha.Hour>horaIngreso && fecha.Hour<horaSalida)
            {
                disp = true;
            }
     
            return disp;
        }
    }
}
