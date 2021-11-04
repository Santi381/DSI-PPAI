using System;
using System.Data;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DSI.Entidades
{
    class Escuela
    {
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string TeleCelular { get; set; }
        public string TeleFijo { get; set; }

        public string mostrarNombre
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
