using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class Participacao
    {
        [Key]
        public int idParticipacao { get; set; }
        public string descricao { get; set; }
       
        public Campeonato Campeonato { get; set; }
     
        public Usuario Usuario { get; set; }
        
        public Equipe Equipe { get; set; }
    }
}
