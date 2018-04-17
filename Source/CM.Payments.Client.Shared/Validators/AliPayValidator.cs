using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    public class AliPayValidator : AbstractValidator<AliPayPaymentRequest>
    {
        public AliPayValidator()
        {
            this.RuleFor(p => p.Details).SetValidator(new AliPayDetailsValidator());
        }
    }
}
