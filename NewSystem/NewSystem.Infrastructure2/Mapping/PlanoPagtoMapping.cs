using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("PLANOPAGTO")]
    public class PlanoPagtoMapping 
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(80)]
        public string Descricao { get; set; }

        [Column("NUMPARCELAS")]
        [Required]
        public int NumParcelas { get; set; }

        [Column("DIASINICIAL")]
        [Required]
        public int DiasInicial { get; set; }

        [Column("INATIVO")]
        public bool Inativo { get; set; }
    
    }
}
