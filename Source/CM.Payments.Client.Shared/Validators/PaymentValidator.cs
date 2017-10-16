using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CM.Payments.Client.Model;
using FluentValidation;

namespace CM.Payments.Client.Validators
{
    internal sealed class PaymentValidator : PaymentValidatorBase<PaymentRequest>
    {
        public PaymentValidator()
        {
            this.RuleFor(p => p.Amount).NotEmpty();
            this.AddValidator<IdealPaymentRequest, IdealValidator>();
            this.AddValidator<PayPalPaymentRequest, PayPalValidator>();
            this.AddValidator<AfterPayPaymentRequest, AfterPayValidator>();
            this.AddValidator<CreditcardPaymentRequest, CreditcardValidator>();
            this.AddValidator<SofortPaymentRequest, SofortValidator>();
            this.AddValidator<BancontactPaymentRequest, BancontactValidator>();
            this.AddValidator<WireTransferPaymentRequest, WireTransferValidator>();
            this.AddValidator<DirectDebitPaymentRequest, DirectDebitValidator>();
        } 
    }
}