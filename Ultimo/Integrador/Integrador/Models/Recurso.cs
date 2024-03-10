﻿using System;
using System.Collections.Generic;

namespace Integrador.Models
{
    public partial class Recurso
    {
        public Recurso()
        {
            IdReservas = new HashSet<Reserva>();
        }

        public int IdRecurso { get; set; }
        public string? NombreRecurso { get; set; }
        public string? DescripcionRecurso { get; set; }
        public int? CantidadRecurso { get; set; }
        public decimal? CostoRecurso { get; set; }
        public bool? DisponibilidadRecurso { get; set; }

        public virtual ICollection<Reserva> IdReservas { get; set; }
    }
}
