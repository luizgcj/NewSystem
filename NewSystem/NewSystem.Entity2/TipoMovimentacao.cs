using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Entity
{
    public class TipoMovimentacao : BaseClass
    {
        public string TipoMov { get; set; }
        public string Descricao { get; set; }
        public bool BaixaEstoque { get; set; }
        public bool Fiscal { get; set; }
        public bool GeraFinanceiro { get; set; }
        public bool Inativo { get; set; }
    }
}
