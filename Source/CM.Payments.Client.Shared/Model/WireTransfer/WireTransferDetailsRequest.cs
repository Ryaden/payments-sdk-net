using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// In depth details of the Wire Transfer payment request.
    /// </summary>
    [PublicAPI]
    public class WireTransferDetailsRequest : DetailsRequest
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}