using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class Cidade : BaseClass
    {
        public string Descricao { get; set; }  
        public int EstadoId { get; set; }

        [IgnoreDataMember]
        public Estado Estado { get; set; }

        public int CodigoIBGE { get; set; }

    }
}
