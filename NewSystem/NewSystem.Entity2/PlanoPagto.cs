using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSystem.Entity
{
    public class PlanoPagto : BaseClass
    {
        public string Descricao { get; set; }
        public int NumParcelas { get; set; }
        public int DiasInicial { get; set; }
        public int DiasIntervalo { get; set; }
        public bool Inativo { get; set; }
    }
}
