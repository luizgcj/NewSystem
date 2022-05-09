using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSystem.Infrastructure.Mapping
{
    [Table("PESSOA")]
    public class PessoaMapping 
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("DATA_CRIACAO")]
        [Required]
        public DateTime DataCriacao { get; set; }

        [Column("CLIENTE")]
        [Required]
        public bool Cliente { get; set; }

        [Column("FORNECEDOR")]
        [Required]
        public bool Fornecedor { get; set; }

        [Column("TRANSPORTADORA")]
        [Required]
        public bool Transportadora { get; set; }

        [Column("NOME")]
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Column("ENDERECO")]
        [Required]
        [MaxLength(100)]
        public string Endereco { get; set; }

        [Column("NUMERO")]
        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }

        [Column("COMPLEMENTO")]
        [Required]
        [MaxLength(50)]
        public string Complemento { get; set; }

        [Column("CEP")]
        [Required]
        [MaxLength(8)]
        public string Cep { get; set; }

        [Column("BAIRRO")]
        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Column("CIDADEID")]
        [Required]     
        public int CidadeId { get; set; }

        [Column("TIPOPESSOA")]
        [Required]
        [MaxLength(1)]
        public string TipoPessoa { get; set; }

        [Column("CPFCNPJ")]
        [Required]
        [MaxLength(14)]
        public string CpfCnpj { get; set; }

        [Column("RG_IE")]     
        [MaxLength(30)]
        public string RgIe { get; set; }

        [Column("INATIVO")]       
        public bool Inativo { get; set; }
       
    }
   
}
