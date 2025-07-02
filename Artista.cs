using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{
    public class Artista
    {
        [Key] public int Id { get; set; }
        [Required] public string NombreArtistico { get; set; }
        public string? Biografia { get; set; }
        public GeneroMusical GeneroMusical { get; set; }
        public Perfil? Perfil { get; set; }
        public List<Cancion>? Canciones { get; set; }
    }
}
