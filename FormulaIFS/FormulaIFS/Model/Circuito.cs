using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
   public class Circuito
    {

        [Key]
        public int idCircuito { get; set; }
        [Required]
        public int voltasTreino { get; set; }
        [Required]
        public int voltasDisputa { get; set; }
        
        public string imagem { get; set; }
        [Required]
        public string tempoMaximo { get; set; }
        [Required]
        public string complexidade { get; set; }
        [Required]
        public string tamanho { get; set; }
        [Required]
        public string tentativasTreino { get; set; }
        [Required]
        public string tentativasDisputa { get; set; }

        public TipoCircuito TipoCircuito { get; set; }

        public List<Campeonato> Campeonatos { get; set; }
    }
}
