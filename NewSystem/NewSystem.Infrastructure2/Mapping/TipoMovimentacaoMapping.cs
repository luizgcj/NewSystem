using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("TIPO_MOVIMENTACAO")]
    public class TipoMovimentacaoMapping 
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("TIPOMOV")]
        [Required]
        [MaxLength(1)]
        public string TipoMov { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Column("BAIXAESTOQUE")]
        [Required]
        public bool BaixaEstoque { get; set; }

        [Column("FISCAL")]
        [Required]
        public bool Fiscal { get; set; }

        [Column("GERAFINANCEIRO")]
        [Required]
        public bool GeraFinanceiro { get; set; }

        [Column("INATIVO")]
        [Required]
        public bool Inativo { get; set; }

        
    }
}
