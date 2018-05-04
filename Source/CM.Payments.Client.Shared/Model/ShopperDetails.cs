using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// Details about the shopper.
    /// </summary>
    public class ShopperDetails
    {
        /// <summary>
        /// Firstname
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        /// <summary>
        /// Lastname
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// Language
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }
    
        /// <summary>
        /// Shipping address details
        /// </summary>
        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }
}
