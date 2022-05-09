using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class ItemMovimentacaoTributacao
    {
        public int ItemMovimentacaoId { get; set; }
        public int TributacaoId { get; set; }
        public double BaseCalculoBruto { get; set; }
        public double PercReducaoBase { get; set; }
        public double BaseCalculo { get; set; }
        public double VrImposto { get; set; }
    }
}
