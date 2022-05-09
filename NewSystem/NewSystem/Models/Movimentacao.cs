using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class Movimentacao : BaseClass
    {
        public int TipoMovimentacaoId { get; set; }
        public int CFOP { get; set; }
        public int PessoaId { get; set; }
        public int FormaPagtoId { get; set; }
        public int PlanoPagtoId { get; set; }
        public bool Cancelada { get; set; }
    }
}
