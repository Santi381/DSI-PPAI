using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DSI.Entidades
{
    class ReservaVisita
    {
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public int duracionEstimada { get; set; }
        public DateTime fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public int horaFinReal { get; set; }
        public int horaInicioReal { get; set; }
        public int nroReserva { get; set; }
        public string nombre { get; set; }
        public Usuario user { get; set; }
        public Escuela escuela { get; set; }
        public List<Exposicion> expos { get; set; }
        public List<Empleado> guias { get; set; }

        public string nombreReserva
        {
            get => nombre;
            set => nombre = value;
        }

        public ReservaVisita() { }

        public ReservaVisita(int nroReserva, Usuario user, DateTime fechaCreacion, DateTime fechaReserva, int duracionEstimda, List<Exposicion> expos, Escuela escuela, int cantVisitantes,List<Empleado> guias)
        {
            this.nroReserva = nroReserva;
            this.user = user;
            this.fechaHoraCreacion = fechaCreacion;
            this.fechaHoraReserva = fechaReserva;
            this.duracionEstimada = duracionEstimada;
            this.expos = expos;
            this.guias = guias;
            this.escuela = escuela;
            this.cantidadAlumnos = cantVisitantes;

        }
    }
}
