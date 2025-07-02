using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{
    public class ArtistaCliente
    {
        [Key] public int Id { get; set; }
        [Required] public string Nombre { get; set; }
        [Required] public string Apellido { get; set; }
        [Required] public string NombreArtistico { get; set; }
        [Required]public GeneroMusical GeneroMusical { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required] public string ContraseñaHash { get; set; }
        [Required] public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
