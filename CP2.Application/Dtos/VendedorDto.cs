using CP2.Domain.Interfaces.Dtos;
using FluentValidation;

namespace CP2.Application.Dtos
{
    public class VendedorDto : IVendedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public DateTime DataContratacao { get; set; }
        public bool ComissaoPercentual { get; set; }
        public bool MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new VendedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class VendedorDtoValidation : AbstractValidator<VendedorDto>
    {
        public VendedorDtoValidation()
        {
            RuleFor(v => v.Nome)
                .NotEmpty().WithMessage("O nome não pode ser vazio.")
                .Length(2, 100).WithMessage("O nome deve ter entre 2 e 100 caracteres.");

            RuleFor(v => v.Email)
                .NotEmpty().WithMessage("O email não pode ser vazio.")
                .EmailAddress().WithMessage("O email deve ser válido.");

            RuleFor(v => v.DataNascimento)
                .NotEmpty().WithMessage("A data de nascimento não pode ser vazia.")
                .Must(data => data < DateTime.Now).WithMessage("A data de nascimento deve ser no passado.");

            RuleFor(v => v.Telefone)
                .NotEmpty().WithMessage("O telefone não pode ser vazio.")
                .Matches(@"^\d{10,11}$").WithMessage("O telefone deve conter 10 ou 11 dígitos.");

            RuleFor(v => v.Endereco)
                .NotEmpty().WithMessage("O endereço não pode ser vazio.");

            RuleFor(v => v.DataContratacao)
                .NotEmpty().WithMessage("A data de contratação não pode ser vazia.")
                .Must(data => data <= DateTime.Now).WithMessage("A data de contratação deve ser uma data válida no presente ou no passado.");

            RuleFor(v => v.CriadoEm)
                .NotEmpty().WithMessage("A data de criação não pode ser vazia.")
                .Must(data => data <= DateTime.Now).WithMessage("A data de criação deve ser uma data válida no presente ou no passado.");
        }
    }
}
