using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Orders
{
    [DataContract]
    public class SpotOrder
    {
        [DataMember(Order = 1)]
        public string OrderId { get; set; }

        [DataMember(Order = 2)]
        public OrderType Type { get; set; }

        [DataMember(Order = 3)]
        public string InstrumentSymbol { get; set; }

        [DataMember(Order = 4)]
        public OrderSide Side { get; set; }

        [DataMember(Order = 5)]
        public double Price { get; set; }

        [DataMember(Order = 6)]
        public double Volume { get; set; }

        [DataMember(Order = 7)]
        public double RemainingVolume { get; set; }

        [DataMember(Order = 8)]
        public DateTime CreatedTime { get; set; }

        [DataMember(Order = 9)]
        public DateTime LastUpdate { get; set; }

        [DataMember(Order = 10)]
        public OrderStatus Status { get; set; }

        [DataMember(Order = 11)]
        public long LastSequenceId { get; set; }

        public SpotOrder()
        {
        }

        public SpotOrder(string orderId, OrderType type, string instrumentSymbol, OrderSide side, double price, double volume, double remainingVolume, DateTime createdTime, DateTime lastUpdate, OrderStatus status, long lastSequenceId)
        {
            OrderId = orderId;
            Type = type;
            InstrumentSymbol = instrumentSymbol;
            Side = side;
            Price = price;
            Volume = volume;
            RemainingVolume = remainingVolume;
            CreatedTime = createdTime;
            LastUpdate = lastUpdate;
            Status = status;
            LastSequenceId = lastSequenceId;
        }
    }
}