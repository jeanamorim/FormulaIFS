using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class Equipe
    {
        [Key]
        public int idEquipes { get; set; }
        [Required]
        public string nomeEquipes { get; set; }
        [Required]
        public string siglaEquipe { get; set; }

        public string imagem { get; set; }
        [Required]
        public string situacao { get; set; }

        public Campeonato Campeonato { get; set; }

        public SituacaoEquipe SituacaoEquipe { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
