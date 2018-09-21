using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class Usuario
    {

        [Key]
        public int idUsuario { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public int equipe { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public Campeonato Campeonato { get; set; }

        public List<Equipe> Equipes { get; set; }
    }
}
