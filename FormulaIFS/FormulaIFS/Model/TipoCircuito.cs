using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
   public class TipoCircuito
    {
        [Key]
        public int idTipoCircuito { get; set; }
        [Required]
        public string descricao { get; set; }
    }
}
