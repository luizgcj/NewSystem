using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class Tributacao : BaseClass
    {
        public string Descricao { get; set; }
        public double Aliquota { get; set; }
        public bool Inativo { get; set; }
    }
}
