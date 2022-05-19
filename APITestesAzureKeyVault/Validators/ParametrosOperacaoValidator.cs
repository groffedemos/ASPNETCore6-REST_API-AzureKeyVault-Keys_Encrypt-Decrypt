using FluentValidation;
using APITestesAzureKeyVault.Models;

namespace APITestesAzureKeyVault.Validators;

public class ParametrosOperacaoValidator : AbstractValidator<ParametrosOperacao>
{
    public ParametrosOperacaoValidator()
    {
        RuleFor(p => p.Key).NotEmpty().WithMessage("Preencha o campo 'Key'");
        RuleFor(p => p.Conteudo).NotEmpty().WithMessage("Preencha o campo 'Conteudo'");
    }                
}