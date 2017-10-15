using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    internal sealed class PaymentValidator : PaymentValidatorBase<PaymentRequest>
    {
        static readonly List<string> supportedCurrencies = new List<string> { "EUR", "ZAR", "GBP", "USD", "SGD", "HKD", "CNY" };

        public PaymentValidator()
        {
            this.RuleFor(p => p.Amount).NotEmpty();
            this.RuleFor(p => p.Currency).Must(BeAValidIsoFormat).WithMessage("'Currency' must be in the right ISO format and in supported currencies list.");
            this.AddValidator<IdealPaymentRequest, IdealValidator>();
            this.AddValidator<PayPalPaymentRequest, PayPalValidator>();
            this.AddValidator<AfterPayPaymentRequest, AfterPayValidator>();
            this.AddValidator<CreditcardPaymentRequest, CreditcardValidator>();
            this.AddValidator<SofortPaymentRequest, SofortValidator>();
            this.AddValidator<BancontactPaymentRequest, BancontactValidator>();
            this.AddValidator<WireTransferPaymentRequest, WireTransferValidator>();
            this.AddValidator<DirectDebitPaymentRequest, DirectDebitValidator>();
        } 

        private static bool BeAValidIsoFormat(string currency)
        {
            return supportedCurrencies.Contains(currency);
        }
    }
}