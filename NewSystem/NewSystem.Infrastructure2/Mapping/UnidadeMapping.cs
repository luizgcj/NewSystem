using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("UNIDADE")]
    public class UnidadeMapping 
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

        [Column("SIGLA")]
        [Required]
        [MaxLength(6)]
        public string Sigla { get; set; }

        [Column("QTDEDECIMAIS")]
        [Required]
        public int QtdeDecimais { get; set; }

        [Column("INATIVO")]
        [Required]
        public bool Inativo { get; set; }        
    }
}
