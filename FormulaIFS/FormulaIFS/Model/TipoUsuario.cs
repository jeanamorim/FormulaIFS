using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaIFS.Model
{
   public class TipoUsuario
    {
        [Key]
        public int idTipoUsuario { get; set; }
        [Required]
        public string descricaoTipo { get; set; }
    }
}
