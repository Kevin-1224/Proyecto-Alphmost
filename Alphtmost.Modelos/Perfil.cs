using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class Perfil
    {
        [Key] public int Id { get; set; }
        public string NombrePerfil { get; set; }
        public string? Descripcion { get; set; }
        public string? ImagenPerfilUrl { get; set; }
        public int? UsuarioClienteId { get; set; }
        public int? ArtistaClienteId { get; set; }
        public int? ArtistaId { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public Artista? Artista { get; set; }
        public UsuarioCliente? UsuarioCliente { get; set; }
        public ArtistaCliente? ArtistaCliente { get; set; }
        public List<Seguidor>? Seguidores { get; set; }
    }
}
