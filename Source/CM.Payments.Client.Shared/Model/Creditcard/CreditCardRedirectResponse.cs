using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CM.Payments.Client.Model.Creditcard
{
    public class CreditCardRedirectResponse
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("parameters")]
        public CreditCardParametersResponse Parameters { get; set; }
    }
}
