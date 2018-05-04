using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    public class ShippingAddress
    {
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
