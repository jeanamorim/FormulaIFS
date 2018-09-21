using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class TipoCampeonato
    {
        [Key]
        public int idTipoCampeonato { get; set; }
        [Required]
        public string descricaoCamp { get; set; }
        [Required]
        public string tipoCampeonato { get; set; }
    }
}
