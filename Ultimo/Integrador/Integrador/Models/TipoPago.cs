using System;
using System.Collections.Generic;

namespace Integrador.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Pagos = new HashSet<Pago>();
        }

        public int IdTipoPago { get; set; }
        public string? TipoPago1 { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
