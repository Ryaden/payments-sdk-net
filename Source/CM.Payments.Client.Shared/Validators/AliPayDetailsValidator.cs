using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    public class AliPayDetailsValidator : AbstractValidator<AliPayDetailsRequest>
    {
        public AliPayDetailsValidator()
        {
            this.RuleFor(p => p.Description).NotNull().Length(1, 35);
            this.RuleFor(p => p.PurchaseId).NotNull().Length(1, 35);
        }
    }
}
