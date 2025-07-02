using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphtmost.Enums;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{

    public class Cancion
    {
        [Key] public int Id { get; set; }
        [Required]public string Titulo { get; set; }
        public EstadoCancion Estado { get; set; }
        [Required] public string CancionUrl { get; set; }
        [Required] public string PropietariosDerechos { get; set; }
        public int? UsuarioClienteId { get; set; }
        public int? ArtistaId { get; set; }
        public string GeneroMusical { get; set; }
        public DateTime FechaLanzamiento { get; set; } = DateTime.Now;
        [Required] public string PortadaUrl { get; set; }
        public Artista? Artista { get; set; }
        public ArtistaCliente? ArtistaCliente { get; set; }
        public List<PlayListCancion>? PlaylistCanciones { get; set; }
    }
}
