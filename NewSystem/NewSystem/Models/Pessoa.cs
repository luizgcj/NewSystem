using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NewSystem.Models
{
    public class Pessoa : BaseClass
    {
        public bool Cliente { get; set; }
        public bool Fornecedor { get; set; }
        public bool Transportadora { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public int CidadeId { get; set; }

        [IgnoreDataMember]
        public Cidade Cidade { get; set; }

        public string TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string RgIE { get; set; }

        public bool Inativo { get; set; }
    }
}
