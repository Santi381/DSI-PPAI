using DSI.DAO;
using DSI.Entidades;
using System;
using System.Collections.Generic;

namespace DSI.Gestor
{
    class GestorDeRegistrarVisita
    {
        List<Escuela> listaEscuelas = new List<Escuela>();
        List<Sede> listaSedes = new List<Sede>();
        List<TipoVisita> listaTiposVisita = new List<TipoVisita>();
        List<Exposicion> listaExposiciones = new List<Exposicion>();
        List<Empleado> listaGuias = new List<Empleado>();
        List<Empleado> listaGuiasSeleccionados = new List<Empleado>();
        List<Exposicion> listaExposicionesSeleccionadas = new List<Exposicion>();
        DateTime fechaVisita;
        Escuela selectedEscuela;
        Sede selectedSede;
        TipoVisita selectedTipoVisita;
        int cantidadVisitantes;
        int duracionEstimadaReserva;
        Usuario user;
        int nroReserva;

        public List<string> tomarRegReservaVisita()
        {
            List<string> listaNombreEscuelas = new List<string>();
            buscarEscuelas();
            foreach (Escuela esc in listaEscuelas)
            {
                Console.WriteLine(esc.mostrarNombre);
                listaNombreEscuelas.Add(esc.mostrarNombre);
            }
            return listaNombreEscuelas;
        }

        public void buscarEscuelas()
        {
            List<Escuela> escuelas = DAO_Escuela.getEscuelas();
            foreach (Escuela name in escuelas)
            {
                this.listaEscuelas.Add(name);
            }
        }

        public void tomarSeleccionEscuela(string name)
        {
            foreach (Escuela esc in listaEscuelas)
            {
                if (esc.mostrarNombre == name)
                {
                    this.selectedEscuela = esc;
                }
            }
        }

        public List<string> tomarCantidadDeVisitantes(int num)
        {
            List<string> listaNombreSede = new List<string>();
            this.cantidadVisitantes = num;
            buscarSedes();
            foreach (Sede sede in listaSedes)
            {
                listaNombreSede.Add(sede.Nombre);
            }
            return listaNombreSede;
        }

        public void buscarSedes()
        {
            List<Sede> sedes = DAO_Sede.getSede();
            foreach (Sede name in sedes)
            {
                this.listaSedes.Add(name);
            }
        }

        public List<string> tomarSeleccionSede(string name)
        {
            List<string> listaTipos = new List<string>();
            buscarTipoVisitas();
            foreach (TipoVisita tipo in listaTiposVisita)
            {
                listaTipos.Add(tipo.mostrarNombre);
            }


            foreach (Sede sede in listaSedes)
            {
                if (sede.Nombre == name)
                {
                    this.selectedSede = sede;
                }
            }

            return listaTipos;
        }

        public void buscarTipoVisitas()
        {
            List<TipoVisita> tipos = DAO_TipoVisita.getTipoVisita();
            foreach (TipoVisita tipo in tipos)
            {
                this.listaTiposVisita.Add(tipo);
            }
        }

        public List<string> tomarSeleccionTipoVisita(string name)
        {
            List<string> listaExpos = new List<string>();
            DateTime fecha = DateTime.Now;
            buscarExpoTemporalesVigentes(fecha);
            foreach (Exposicion tipo in listaExposiciones)
            {
                listaExpos.Add(tipo.nombreExpo);
            }


            foreach (TipoVisita tipo in listaTiposVisita)
            {
                if (tipo.mostrarNombre == name)
                {
                    this.selectedTipoVisita = tipo;
                }
            }

            return listaExpos;
        }

        public void buscarExpoTemporalesVigentes(DateTime fecha)
        {
            List<Exposicion> exposiciones = DAO_Exposiciones.getExposiciones();
            foreach (Exposicion expo in exposiciones)
            {
                this.listaExposiciones.Add(expo);
            }
        }

        public void tomarExposiciones(List<string> expos)
        {
            foreach (Exposicion expo in listaExposiciones)
            {
                foreach (string name in expos)
                {
                    if (expo.nombreExpo == name)
                    {
                        if (expo.esVigente() && expo.tipo.esTemporal())
                        {
                            this.listaExposicionesSeleccionadas.Add(expo);
                        }
                    }
                }
            }
        }

        public List<string> tomarRegReservaVisita(DateTime fecha)
        {
            this.fechaVisita = fecha;
            calcularDuracionEstimadaDeReserva();
            VerificarSobrePasoCapMax(fecha);
            calcularCantidadGuiasNecesarios();
            buscarGuiaDispFechaReserva(fecha);

            List<string> listaNombreGuias = new List<string>();
            foreach (Empleado guia in listaGuias)
            {
                listaNombreGuias.Add(guia.getNombre);
            }

            return listaNombreGuias;

        }

        public void calcularDuracionEstimadaDeReserva()
        {
            int duracionEstimada = 0;
            foreach (Exposicion expo in listaExposicionesSeleccionadas)
            {
                List<DetalleExposicion> asignaciones = DAO_DetalleExposicion.getAsignaciones();
                foreach (DetalleExposicion item in asignaciones)
                {
                    if (item.exposicion == expo.nombreExpo)
                    {
                        List<Obra> obras = DAO_Obra.getObras();
                        foreach (Obra obra in obras)
                        {
                            if (item.obra == obra.Nombre)
                            {
                                duracionEstimada += obra.DuracionExtendida;
                            }
                        }
                    }
                }
            }
            this.duracionEstimadaReserva = duracionEstimada;
        }

        public bool VerificarSobrePasoCapMax(DateTime fecha)
        {
            bool res = false;
            int capacidadMax = selectedSede.CantMaximaVisitantes;
            List<ReservaVisita> reservas = DAO_Reserva.getReservas();
            int cantPersonas = 0;
            foreach (ReservaVisita reserva in reservas)
            {
                if (reserva.fechaHoraReserva == fecha)
                {
                    cantPersonas += reserva.cantidadAlumnos;
                }
            }
            if (cantPersonas > capacidadMax)
            {
                res = true;
            }

            return res;
        }

        public int calcularCantidadGuiasNecesarios()
        {
            int cantMaxGuia = selectedSede.CantMaxPorGuia;
            decimal div = (this.cantidadVisitantes / cantMaxGuia);
            int cantidadGuia = int.Parse(Math.Ceiling(div).ToString());

            return cantidadGuia;
        }

        public void buscarGuiaDispFechaReserva(DateTime fecha)
        {
            List<Empleado> guias = DAO_Empleado.getEmpleado();
            foreach (Empleado guia in guias)
            {
                if (guia.cargo.esGuia() && guia.horario.dispEnFechaHoraReserva(fecha)) //PATRON EXPERTO
                {
                    List<AsignacionVisita> asignaciones = DAO_AsignacionesVisita.getAsignaciones();
                    foreach (AsignacionVisita item in asignaciones)
                    {
                        if (item.empleado == guia.nombre && item.fechaHoraInicio == fecha)
                        {
                            break;
                        }
                        else
                        {
                            this.listaGuias.Add(guia);
                        }
                    }
                }
            }
        }

        public void tomarGuias(List<string> guias)
        {
            foreach (Empleado guia in listaGuias)
            {
                foreach (string name in guias)
                {
                    if (guia.getNombre == name)
                    {
                        this.listaGuiasSeleccionados.Add(guia);
                    }
                }
            }
        }

        public void registrarReserva()
        {
            Sesion actual = DAO_Sesion.getSesion();
            this.user = actual.usuario;
            this.nroReserva = DAO_Reserva.nroReservas();
            if (nroReserva != -1)
            {
                nroReserva = (nroReserva + 1);
            }
            else
            {
                nroReserva = 0;
            }
            ReservaVisita nuevaReserva = new ReservaVisita(this.nroReserva, this.user, DateTime.Now, this.fechaVisita, this.duracionEstimadaReserva, this.listaExposicionesSeleccionadas, this.selectedEscuela, this.cantidadVisitantes, this.listaGuiasSeleccionados);
            foreach (Empleado item in this.listaGuiasSeleccionados)
            {
                AsignacionVisita asig = new AsignacionVisita();
                asig.empleado = item.nombre;
                asig.nroReserva = this.nroReserva;
                asig.fechaHoraInicio = DateTime.Now;
            }
        }

    }
}
