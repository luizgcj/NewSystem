using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace NewSystem.Infrastructure.Mapping
{
    [Table("GRUPO")]
    public class GrupoMapping 
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Column("INATIVO")]
        public bool Inativo { get; set; }    
      
    }
}
