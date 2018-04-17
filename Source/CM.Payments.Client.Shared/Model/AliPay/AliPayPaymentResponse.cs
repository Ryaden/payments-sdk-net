using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// Details of the AliPay payment response.
    /// </summary>
    public class AliPayPaymentResponse : PaymentResponse
    {
        /// <summary>
        /// In depth details of the AliPay response.
        /// </summary>
        [JsonProperty("payment_details")]
        public new AliPayDetailsResponse Details
        {
            get => (AliPayDetailsResponse) base.Details;
            set => base.Details = value;
        }
    }
}
