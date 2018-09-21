using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class Campeonato
    {
        [Key]
        public int idCampeonato { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public int qtdVencedor { get; set; }
        [Required]
        public DateTime dataInicio { get; set; }
        [Required]
        public DateTime dataFim { get; set; }
        [Required]
        public string visibilidade { get; set; }

        public TipoCampeonato TipoCampeonato { get; set; }

        public Categoria Categoria { get; set; }

        public List<Circuito> Circuitos { get; set; }
    }
}
