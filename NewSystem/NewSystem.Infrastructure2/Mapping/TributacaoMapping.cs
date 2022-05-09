using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("TRIBUTACAO")]
    public class TributacaoMapping 
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(30)]
        public string Descricao { get; set; }

        [Column("ALIQUOTA")]
        [Required]
        public double Aliquota { get; set; }

        [Column("INATIVO")]
        [Required]
        public bool Inativo { get; set; }
        
    }
}
