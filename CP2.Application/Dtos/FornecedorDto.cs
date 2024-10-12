using CP2.Domain.Interfaces.Dtos;
using FluentValidation;

namespace CP2.Application.Dtos
{
    public class FornecedorDto : IFornecedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new FornecedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class FornecedorDtoValidation : AbstractValidator<FornecedorDto>
    {
        public FornecedorDtoValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O nome não pode ser vazio.")
                .Length(2, 100).WithMessage("O nome deve ter entre 2 e 100 caracteres.");

            RuleFor(f => f.CNPJ)
                .NotEmpty().WithMessage("O CNPJ não pode ser vazio.")
                .Matches(@"^\d{14}$").WithMessage("O CNPJ deve conter 14 dígitos.");

            RuleFor(f => f.Endereco)
                .NotEmpty().WithMessage("O endereço não pode ser vazio.");

            RuleFor(f => f.Telefone)
                .NotEmpty().WithMessage("O telefone não pode ser vazio.")
                .Matches(@"^\d{10,11}$").WithMessage("O telefone deve conter 10 ou 11 dígitos.");

            RuleFor(f => f.Email)
                .NotEmpty().WithMessage("O email não pode ser vazio.")
                .EmailAddress().WithMessage("O email deve ser válido.");

            RuleFor(f => f.CriadoEm)
                .NotEmpty().WithMessage("A data de criação não pode ser vazia.")
                .Must(data => data <= DateTime.Now).WithMessage("A data de criação deve ser uma data válida no presente ou no passado.");
        }
    }
}
