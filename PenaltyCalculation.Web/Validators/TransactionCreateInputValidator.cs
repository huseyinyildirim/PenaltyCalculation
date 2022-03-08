using FluentValidation;
using PenaltyCalculation.Web.Models;

namespace PenaltyCalculation.Web.Validators
{
    public class TransactionCreateInputValidator : AbstractValidator<IndexViewModel>
    {
        public TransactionCreateInputValidator()
        {
            RuleFor(x => x.CountryId).NotEmpty().WithMessage("Lütfen ülke seçiniz.");
            RuleFor(x => x.PurchaseDate).NotEmpty().WithMessage("Alış tarihi seçiniz.");
            RuleFor(x => x.DeliveryDate).NotEmpty().WithMessage("Teslim tarihi seçiniz.");
        }
    }
}
