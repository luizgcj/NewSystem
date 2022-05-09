using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("MOVIMENTACAO")]
    public class MovimentacaoMapping 
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("NUMERO")]
        [Required]
        public long Numero { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("TIPOMOVIMENTACAOID")]
        [Required]
        public long TipoMovimentacaoId { get; set; }

        [Column("CFOP")]
        public int Cfop { get; set; }

        [Column("PESSOAID")]
        [Required]
        public long PessoaId { get; set; }

        [Column("FORMAPAGTOID")]
        public int FormaPagtoId { get; set; }

        [Column("PLANOPAGTOID")]
        public int PlanoPagtoId { get; set; }

        [Column("CANCELADA")]
        public bool Cancelada { get; set; }
       
    }
   
}
