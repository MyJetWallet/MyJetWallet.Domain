using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Prices
{
    [DataContract]
    public class OrderBook
    {
        [DataMember(Order = 1)] public string Symbol { get; set; }
        [DataMember(Order = 2)] public List<OrderBookLevel> BuyLevels { get; set; }
        [DataMember(Order = 3)] public List<OrderBookLevel> SellLevels { get; set; }
        [DataMember(Order = 4)] public long LastSequenceId { get; set; }
    }
}