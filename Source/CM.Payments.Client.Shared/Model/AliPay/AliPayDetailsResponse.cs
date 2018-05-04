using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// In depth details of the AliPay response.
    /// </summary>
    public sealed class AliPayDetailsResponse : AliPayDetailsRequest, IDetailsResponse
    {

        /// <summary>
        /// URL to where an end-user can execute the payment.
        /// </summary>
        [JsonProperty("authentication_url")]
        public string AuthenticationUrl { get; set; }
    }
}
