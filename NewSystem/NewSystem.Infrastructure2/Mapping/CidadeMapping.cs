using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("CIDADES")]
    public class CidadeMapping 
    {
        [Key]
        [Column("ID")]  
        public int Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Column("CODIGOIBGE")]
        public int CodigoIBGE { get; set; }

        [Column("ESTADOID")]
        public int EstadoId { get; set; }        

       
    }
}
