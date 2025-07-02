using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{

    public class Pago
    {
        [Key]public int Id { get; set; }
        [Required]public int UsuarioClienteId { get; set; }
        [Required]public decimal Monto { get; set; } // Monto del pago
        [Required]public EstadoPago EstadoPago { get; set; } // "Pendiente", "Exitoso", "Fallido"
        [Required] public DateTime FechaPago { get; set; } = DateTime.Now; // Fecha del pago
        public string MetodoPago { get; set; } // Ej. "Tarjeta de Crédito", "PayPal"
        [Required] public TipoPlanPremium Plan { get; set; } // "Normal", "Familiar", "Empresarial"
        public DateTime FechaVencimiento { get; set; } // Fecha de expiración del plan Premium
        public string CodigoInvitacion { get; set; }
        public UsuarioCliente? UsuarioCliente { get; set; }
    }
}
