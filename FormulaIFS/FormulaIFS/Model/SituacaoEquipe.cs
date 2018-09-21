using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class SituacaoEquipe
    {
        [Key]
        public int idSituacaoEquipe { get; set; }
        public string descrição { get; set; }
    }
}
