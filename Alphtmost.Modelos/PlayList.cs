using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class PlayList
    {
        [Key] public int Id { get; set; }
        [Required] public string Nombre { get; set; }

        public int? UsuarioClienteId { get; set; }
        public UsuarioCliente? UsuarioCliente { get; set; }
        public int? ArtistaClienteId { get; set; }
        public ArtistaCliente? ArtistaCliente { get; set; }

        public List<PlayListCancion>? PlaylistCanciones { get; set; }
    }
}
