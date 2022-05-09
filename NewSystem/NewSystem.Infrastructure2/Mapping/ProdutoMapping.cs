using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("PRODUTOS")]
    public class ProdutoMapping 
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("DESCRICAO")]
        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Column("DESCRICAORESUMIDA")]
        [Required]
        [MaxLength(30)]
        public string DescricaoResumida { get; set; }

        [Column("UNIDADEID")]
        [Required]       
        public int UnidadeId { get; set; }

        [Column("NCM")]
        [Required]
        [MaxLength(8)]
        public string Ncm { get; set; }

        [Column("PRCUSTO")]
        [Required]
        public double PrCusto { get; set; }

        [Column("PRMEDIO")]
        [Required]
        public double PrMedio { get; set; }

        [Column("PRVENDA")]
        [Required]
        public double PrVenda { get; set; }

        [Column("GRUPOID")]
        [Required]
        public int GrupoId { get; set; }

        [Column("ICMSID")]       
        public int IcmsId { get; set; }

        [Column("IPIID")]       
        public int IpiId { get; set; }

        [Column("PISID")]       
        public int PisId { get; set; }

        [Column("COFINSID")]       
        public int CofinsId { get; set; }

        [Column("ICMSSTID")]
        public int IcmsStId { get; set; }

        [Column("ICMSIMPID")]      
        public int IcmsImpId { get; set; }

        [Column("PERCREDUCAOBASEICMS")]      
        public double PercReducaoBaseIcms { get; set; }

        [Column("INATIVO")]
        public bool Inativo { get; set; }

    }
}
