using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NewSystem.Entity
{
    public class Produto : BaseClass
    {
        public string Descricao { get; set; }
        public string DescricaoResumida { get; set; }
        public int UnidadeId { get; set; }

        [IgnoreDataMember]
        public Unidade Unidade { get; set; }

        public string NCM { get; set; }
        public double PrCusto { get; set; }
        public double PrMedio { get; set; }
        public double PrVenda { get; set; }
        public int GrupoId { get; set; }

        [IgnoreDataMember]
        public Grupo Grupo { get; set; }

        public int IcmsId { get; set; }      
        public int IpiId { get; set; }
        public int PisId { get; set; }
        public int CofinsId { get; set; }
        public int IcmsStId { get; set; }
        public int IcmsImpId { get; set; }
        public double PercReducaoBaseIcms { get; set; }

        [IgnoreDataMember]
        public ICollection<MovEstoque> MovEstoque { get; set; }

        public bool Inativo { get; set; }

        public Produto()
        {
            MovEstoque = new HashSet<MovEstoque>();
        }
    }
}
