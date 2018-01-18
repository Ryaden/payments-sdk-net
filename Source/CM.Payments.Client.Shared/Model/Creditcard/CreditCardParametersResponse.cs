using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Payments.Client.Model.Creditcard
{
    public class CreditCardParametersResponse
    {
        public string MD { get; set; }
        public string PaReq { get; set; }
        public string TermUrl { get; set; }
    }
}
