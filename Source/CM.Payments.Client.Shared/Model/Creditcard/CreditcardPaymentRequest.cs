using JetBrains.Annotations;
using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// Details of the credit card payment request.
    /// </summary>
    [PublicAPI]
    public sealed class CreditcardPaymentRequest : PaymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("capture")]
        public bool Capture { get; set; }

        /// <summary>
        /// Whether a recurring payment needs to be created, or not.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Unique identifier of the recurring payment.
        /// </summary>
        [JsonProperty("recurring_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringId { get; set; }

        /// <summary>
        /// Contains more in depth information about the Payment.
        /// </summary>
        [JsonProperty("payment_details")]
        public CreditcardDetailsRequest Details { get; set; }

        /// <summary>
        /// Payment method used to make the payment.
        /// </summary>
        internal override string Method { get; } = "Creditcard";
    }
}