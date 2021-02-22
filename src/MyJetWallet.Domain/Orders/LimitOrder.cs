using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Orders
{
    [DataContract]
    public class LimitOrder
    {
        [DataMember(Order = 1)]
        public string OrderId { get; set; }

        [DataMember(Order = 2)]
        public string WalletId { get; set; }

        [DataMember(Order = 3)]
        public OrderType Type { get; set; }

        [DataMember(Order = 4)]
        public string InstrumentSymbol { get; set; }

        [DataMember(Order = 5)]
        public OrderSide Direction { get; set; }

        [DataMember(Order = 6)]
        public decimal Price { get; set; }

        [DataMember(Order = 7)]
        public decimal Volume { get; set; }

        [DataMember(Order = 8)]
        public decimal FilledVolume { get; set; }

        [DataMember(Order = 9)]
        public DateTime CreatedTime { get; set; }

        [DataMember(Order = 10)]
        public DateTime LastUpdate { get; set; }

        [DataMember(Order = 11)]
        public OrderStatus Status { get; set; }

        [DataMember(Order = 12)]
        public long LastSequenceId { get; set; }
    }
}