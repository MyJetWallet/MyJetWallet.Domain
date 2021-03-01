using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Prices
{
    [DataContract]
    public class TradeVolume
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public DateTime DateTime { get; set; }

        [DataMember(Order = 5)]
        public string LiquidityProvider { get; set; }

        [DataMember(Order = 6)]
        public double Price { get; set; }

        [DataMember(Order = 7)]
        public double Volume { get; set; }

    }
}