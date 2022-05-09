using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("ITEM_MOVIMENTACAO_TRIBUTACAO")]   
    [Index(nameof(ItemMovimentacaoId), nameof(TributacaoId), IsUnique = true)]
    public class ItemMovimentacaoTributacaoMapping
    {    

        [Key]
        [Column("Id")]
        public long Id { get; set; }

        [Column("ITEMMOVIMENTACAOID")]
        [Required]     
        public long ItemMovimentacaoId { get; set; }

        [Column("TRIBUTACAOID")]   
        [Required]
        public long TributacaoId { get; set; }

        [Column("BASECALCULOBRUTO")]
        [Required]
        public double BaseCalculoBruto { get; set; }

        [Column("PERCREDUCAOBASE")]
        public double PercReducaoBase { get; set; }

        [Column("BASECALCULO")]
        [Required]
        public double BaseCalculo { get; set; }

        [Column("VRIMPOSTO")]
        [Required]
        public double VrImposto { get; set; }
       
    }
}
