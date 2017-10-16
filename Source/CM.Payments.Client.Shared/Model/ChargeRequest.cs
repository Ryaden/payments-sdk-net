﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CM.Payments.Client.Model
{
    /// <summary>
    /// Details of the charge request.
    /// </summary>
    public class ChargeRequest
    {
        /// <summary>
        /// Total amount to be paid for the charge.
        /// </summary>
        [JsonProperty("amount")]
        [JsonRequired]
        public double Amount { get; set; }

        /// <summary>
        /// Currency code in ISO-4217 format.
        /// </summary>
        [JsonProperty("currency")]
        [JsonRequired]
        public string Currency { get; set; }

        /// <summary>
        /// List of payments.
        /// </summary>
        [JsonProperty("payments")]
        [JsonRequired]
        public IEnumerable<PaymentRequest> Payments { get; set; }

        /// <summary>
        /// DDP feature: Client language
        /// </summary>
        [JsonProperty("language")]
        [JsonRequired]
        public string Language { get; set; }

        /// <summary>
        /// DDP feature: Emailaddress
        /// </summary>
        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

    }
}