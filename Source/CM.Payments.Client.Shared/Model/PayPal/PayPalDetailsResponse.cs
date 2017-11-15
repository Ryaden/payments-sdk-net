﻿using JetBrains.Annotations;
using Newtonsoft.Json;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// In depth details of the PayPal payment response.
    /// </summary>
    [PublicAPI]
    public sealed class PayPalDetailsResponse : PayPalDetailsRequest, IDetailsResponse
    {
        /// <summary>
        /// Transaction costs PayPal charged for the transaction.
        /// </summary>
        [JsonProperty("fee_amount")]
        public string Amount { get; set; }

        /// <summary>
        /// City of the user who paid the charge.
        /// </summary>
        [JsonProperty("payer_city")]
        public string City { get; set; }

        /// <summary>
        /// Currency in which PayPal charged the transaction costs.
        /// </summary>
        [JsonProperty("fee_currency")]
        public string Currency { get; set; }

        /// <summary>
        /// E-mail address of the user who paid the charge.
        /// </summary>
        [JsonProperty("payer_email")]
        public string Email { get; set; }

        /// <summary>
        /// First name of the user who paid the charge.
        /// </summary>
        [JsonProperty("payer_first_name")]
        public string Firstname { get; set; }

        /// <summary>
        /// Last name of the user who paid the charge
        /// </summary>
        [JsonProperty("payer_last_name")]
        public string Lastname { get; set; }

        /// <summary>
        /// The PayPal transaction ID.
        /// </summary>
        [JsonProperty("paypal_sale_id")]
        public string PayPalSaleID { get; set; }

        /// <summary>
        /// URL to where an end-user can execute the payment.
        /// </summary>
        [JsonProperty("authentication_url")]
        public string AuthenticationUrl { get; set; }
    }
}