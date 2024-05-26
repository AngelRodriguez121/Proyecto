﻿namespace Proyecto.Modelos
{
    public class Historial
    {
        public int? Id { get; set; }
        public int? LibroId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
    }
}
