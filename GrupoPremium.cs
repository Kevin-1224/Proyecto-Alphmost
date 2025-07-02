using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class GrupoPremium
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioAdminId { get; set; } // Usuario que pagó y es el admin del grupo
        public UsuarioCliente UsuarioAdmin { get; set; }

        [Required]
        public string CodigoInvitacion { get; set; } // Código único para el grupo

        public DateTime FechaCreacion { get; set; } = DateTime.Now; // Fecha de creación del grupo

        [Required]
        public string TipoPlan { get; set; } // "Familiar" o "Empresarial"

        public List<UsuarioCliente> Miembros { get; set; } // Miembros del grupo (usuarios invitados)

        public int LimiteMiembros { get; set; } // Límite de miembros en el grupo (5 para familiar, 30 para empresarial)
    }
}
