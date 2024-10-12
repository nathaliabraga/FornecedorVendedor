using System;

namespace CP2.Domain.Interfaces.Dtos
{
    public interface IVendedorDto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Email { get; set; }
        DateTime DataNascimento { get; set; }
        string Telefone { get; set; }
        string Endereco { get; set; }
        DateTime DataContratacao { get; set; }
        bool ComissaoPercentual { get; set; }
        bool MetaMensal { get; set; }
        DateTime CriadoEm { get; set; }

        void Validate();
    }
}
