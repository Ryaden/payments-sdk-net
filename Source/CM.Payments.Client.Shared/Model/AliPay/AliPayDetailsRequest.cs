using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// In depth details of the AliPay payment request.
    /// </summary>
    public class AliPayDetailsRequest : DetailsRequest
    {
        /// <summary>
        /// Description of the payment.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
