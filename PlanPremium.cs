using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alphtmost.Enums.Enums;

namespace Alphtmost.Modelos
{
    
    public class PlanPremium
    {
        [Key] public int Id { get; set; }
        [Required] public TipoPlanPremium TipoPlan { get; set; }
        public double Precio { get; set; }
    }
}
