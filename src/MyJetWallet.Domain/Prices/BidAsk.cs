using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Prices
{
    [DataContract]
    public class BidAsk
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public DateTime DateTime { get; set; }

        [DataMember(Order = 3)]
        public decimal Bid { get; set; }

        [DataMember(Order = 4)]
        public decimal Ask { get; set; }

        [DataMember(Order = 5)]
        public string LiquidityProvider { get; set; }
    }
}