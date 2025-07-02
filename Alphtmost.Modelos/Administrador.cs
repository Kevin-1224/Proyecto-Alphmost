using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class Administrador
    {
        [Key] public int Id { get; set; }
        [Required] public string Nombre { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        [Required] public string ContraseñaHash { get; set; }

    }
}
