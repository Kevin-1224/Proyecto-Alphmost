using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class Seguidor
    {
        [Key]public int Id { get; set; }
        public int UsuarioClienteId { get; set; }
        public UsuarioCliente? UsuarioCliente { get; set; }
        public int PerfilId { get; set; }
        public Perfil? Perfil { get; set; }
        public DateTime FechaSeguimiento { get; set; } = DateTime.Now;
    }
}
