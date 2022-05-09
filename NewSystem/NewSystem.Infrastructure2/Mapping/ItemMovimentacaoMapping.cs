using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("ITEM_MOVIMENTACAO")]
    public class ItemMovimentacaoMapping 
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("MOVIMENTACAOID")]
        [Required]
        public long MovimentacaoId { get; set; }

        [Column("NUMITEM")]
        [Required]
        public int NumItem { get; set; }

        [Column("CFOP")]
        public int Cfop { get; set; }

        [Column("PRODUTOID")]
        [Required]
        public long ProdutoId { get; set; }

        [Column("QUANTIDADE")]
        [Required]
        public double Quantidade { get; set; }

        [Column("VRUNITARIO")]
        [Required]
        public double VrUnitario { get; set; }

        [Column("PERCDESCONTO")]      
        public double PercDesconto { get; set; }

        [Column("VRDESCONTO")]
        public double VrDesconto { get; set; }

        [Column("PERCACRESCIMO")]
        public double PercAcrescimo { get; set; }

        [Column("VRACRESCIMO")]
        public double VrAcrescimo { get; set; }

        [Column("VRTOTAL")]
        [Required]
        public double VrTotal { get; set; }
       
    }
    
}
