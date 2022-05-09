using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("ESTADOS")]
    public class EstadoMapping 
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Column("UF")]
        [Required]
        [MaxLength(2)]
        public string UF { get; set; }
        
    }
}
