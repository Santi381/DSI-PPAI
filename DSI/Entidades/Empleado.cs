using System;

namespace DSI.Entidades
{
    class Empleado
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string dni { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string mail { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public HorarioEmpleado horario { get; set; }
        public Cargo cargo { get; set; }

        public string getNombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
