using System;
using System.Data;
using System.Data.SqlClient;

namespace DSI.Entidades
{
    class Exposicion
    {
        DateTime fechaFin;
        DateTime fechaFinReplanificada;
        DateTime fechaInicio;
        DateTime fechaInicioReplanificada;
        DateTime horaApertura;
        DateTime horaCierre;
        public  TipoExposicion tipo;
        PublicoDestino publico;
        string nombre;

        public string nombreExpo
        {
            get => nombre;
            set => nombre = value;
        }

        public DateTime fechaFinReplanificadaExpo
        {
            get => fechaFinReplanificada;
            set => fechaFinReplanificada = value;
        }

        public DateTime fechaInicioExpo
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }

        public DateTime fechaInicioReplanificadaExpo
        {
            get => fechaInicioReplanificada;
            set => fechaInicioReplanificada = value;
        }

        public DateTime horaAperturaExpo
        {
            get => horaApertura;
            set => horaApertura = value;
        }

        public DateTime horaCierreExpo
        {
            get => horaCierre;
            set => horaCierre = value;
        }

        public DateTime fechafinExpo
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public bool esVigente()
        {
            bool res = false;
            if (DateTime.Now >= fechaInicio && DateTime.Now < fechaFin)
            {
                res = true;
            }
            return res;
        }
    }
}
