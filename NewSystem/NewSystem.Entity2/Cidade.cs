using System.Runtime.Serialization;

namespace NewSystem.Entity
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
