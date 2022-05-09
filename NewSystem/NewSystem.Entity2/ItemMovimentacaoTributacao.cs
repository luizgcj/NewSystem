using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Entity
{
    public class ItemMovimentacaoTributacao
    {
        public long Id { get; set; }
        public int ItemMovimentacaoId { get; set; }
        public int TributacaoId { get; set; }
        public double BaseCalculoBruto { get; set; }
        public double PercReducaoBase { get; set; }
        public double BaseCalculo { get; set; }
        public double VrImposto { get; set; }
    }
}
