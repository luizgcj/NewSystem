using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("MOV_ESTOQUE")]
    public class MovEstoqueMapping 
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("PRODUTOID")]
        [Required]
        public long ProdutoId { get; set; }

        [Column("QUANTIDADE")]
        [Required]
        public double Quantidade { get; set; }

        
    }
   
}
