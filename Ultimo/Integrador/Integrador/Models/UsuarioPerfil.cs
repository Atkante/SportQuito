using System;
using System.Collections.Generic;

namespace Integrador.Models
{
    public partial class UsuarioPerfil
    {
        public UsuarioPerfil()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdUperfil { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdPerfil { get; set; }

        public virtual Perfil? IdPerfilNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
