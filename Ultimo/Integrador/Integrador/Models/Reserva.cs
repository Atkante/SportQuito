using System;
using System.Collections.Generic;

namespace Integrador.Models
{
    public partial class Reserva
    {
        public Reserva()
        {
            Pagos = new HashSet<Pago>();
            IdRecursos = new HashSet<Recurso>();
        }

        public int IdReserva { get; set; }
        public decimal? CostoReserva { get; set; }
        public DateTime? FechaReserva { get; set; }
        public TimeSpan? HoraReserva { get; set; }
        public int? IdUperfil { get; set; }
        public int? IdInstalacionDeportiva { get; set; }

        public virtual InstalacionesDeportiva? IdInstalacionDeportivaNavigation { get; set; }
        public virtual UsuarioPerfil? IdUperfilNavigation { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }

        public virtual ICollection<Recurso> IdRecursos { get; set; }
    }
}
