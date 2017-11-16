using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    internal sealed class SofortDetailsValidator : AbstractValidator<SofortDetailsRequest>
    {
        public SofortDetailsValidator()
        {
            this.RuleFor(r => r.Description).NotEmpty().Length(1, 35);
        }
    }
}