using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Entity
{
    public class ItemMovimentacao : BaseClass
    {
        public int MovimentacaoId { get; set; }
        public int NumItem { get; set; }
        public int CFOP { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public double VrUnitario { get; set; }
        public double PercDesconto { get; set; }
        public double VrDesconto { get; set; }
        public double PercAcrescimo { get; set; }
        public double VrAcrescimo { get; set; }
        public double VrTotal { get; set; }
    }
}
