using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_vendedor")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public DateTime DataContratacao { get; set; }
        public bool ComissaoPercentual { get; set; }
        public bool MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public FornecedorEntity? Fornecedor { get; set; }

    }
}
