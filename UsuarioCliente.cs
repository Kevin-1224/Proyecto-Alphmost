using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{


    public class UsuarioCliente
    {
        [Key] public int Id { get; set; }
        [Required] public string Nombre { get; set; }
        [Required] public string Apellido { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required] public string ContraseñaHash { get; set; }
        [Required] public Genero Genero { get; set; }
        public bool EsPremium { get; set; } = false;
        [Required] public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime? FechaVencimientoPremium { get; set; }
        public string CodigoInvitacion { get; set; } // Código de invitación en caso de ser invitado
        public int? GrupoId { get; set; } // Relación con el grupo al que pertenece (si aplica)
        public GrupoPremium? GrupoPremium { get; set; } // Grupo asociado
        public List<Pago>? Pagos { get; set; }

        public List<Cancion>?Canciones { get; set; } 
    }
}
