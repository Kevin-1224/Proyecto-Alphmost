using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class CodigoInvitacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Codigo { get; set; } // Código único

        [Required]
        public int UsuarioClienteId { get; set; }
        public UsuarioCliente? UsuarioCliente { get; set; } // Admin que genera el código

        public DateTime FechaGeneracion { get; set; } = DateTime.Now; // Fecha en que se generó el código

        public DateTime? FechaExpiracion { get; set; } // Fecha de expiración del código
    }
}
