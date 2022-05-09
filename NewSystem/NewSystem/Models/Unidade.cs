using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class Unidade : BaseClass
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public int QtdeDecimais { get; set; }
        public bool Inativo { get; set; }
    }
}
