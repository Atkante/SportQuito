using System;
using System.Collections.Generic;

namespace Integrador.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            UsuarioPerfils = new HashSet<UsuarioPerfil>();
        }

        public int IdPerfil { get; set; }
        public string? TipoPerfil { get; set; }

        public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; set; }
    }
}
