using System.Collections.Generic;
using System.Globalization;
using System.Linq;
// ReSharper disable once RedundantUsingDirective
using System.Reflection;
using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    internal sealed class ChargeValidator : AbstractValidator<ChargeRequest>
    {

        static readonly List<string> supportedCurrencies = new List<string> { "EUR", "ZAR", "GBP", "USD", "SGD", "HKD", "CNY" };

        public ChargeValidator()
        {
            this.RuleFor(c => c.Amount).NotEmpty();
            this.RuleFor(c => c.Currency).NotEmpty().Must(BeAValidIsoFormat).WithMessage("'Currency' must be in the supported currencies list.");
            this.RuleFor(c => c.Payments)
                .Must(ContainOneItem)
                .WithMessage("'Payments' must contain '1' payment.")
                .Must(BeImplemented)
                .WithMessage("'Wire Transfer' is not implemented yet.'")
                .SetCollectionValidator(new PaymentValidator());
        }

        private static bool BeAValidIsoFormat(string currency)
        {
            return supportedCurrencies.Contains(currency);
        }

        private static bool BeImplemented(IEnumerable<PaymentRequest> payments)
        {
            var objectType = payments?.First().GetType();
            return !typeof(WireTransferPaymentRequest).IsAssignableFrom(objectType);
        }

        private static bool ContainOneItem(IEnumerable<PaymentRequest> payments)
        {
            return payments?.Count() == 1;
        }
    }
}