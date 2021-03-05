using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Prices
{
    [DataContract]
    public class OrderBookLevel
    {
        public OrderBookLevel(decimal price, decimal volume, long sequenceId)
        {
            Price = price;
            Volume = volume;
            SeqId = sequenceId;
        }

        public OrderBookLevel()
        {
        }

        [DataMember(Order = 1)] public decimal Price { get; set; }
        [DataMember(Order = 2)] public decimal Volume { get; set; }
        [DataMember(Order = 3)] public decimal SeqId { get; set; }
    }
}