using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }
        [Required]
        public string nomeCategoria { get; set; }
        
        public string descricaoCategoria { get; set; }
    }
}
