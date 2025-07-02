using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{ 

    public class Transaccion
    {
        [Key]public int Id { get; set; }
        public int PagoId { get; set; }

        // Estado de la transacción (Aprobada, Rechazada, Pendiente)
        public EstadoTransaccion EstadoTransaccion { get; set; }

        // Fecha de la transacción
        public DateTime FechaTransaccion { get; set; } = DateTime.Now;

        // Detalles adicionales de la transacción
        public string DetalleTransaccion { get; set; }

        // Monto de la transacción (aunque también está en Pago, puede ser útil aquí)
        [Required] public double Monto { get; set; }
        public Pago? Pago { get; set; }
    }
}
