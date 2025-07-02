using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphtmost.Modelos
{
    public class PlayListCancion
    {
        [Key]
        public int Id { get; set; }

        public int PlaylistId { get; set; }
        public PlayList? Playlist { get; set; }

        public int CancionId { get; set; }
        public Cancion? Cancion { get; set; }
    }
}
