using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Assets
{
    public interface ISpotInstrumentIdentity : IJetBrokerIdentity
    {
        /// <summary>
        /// Uniq ID of spot instrument (asset pair) into the broker 
        /// </summary>
        string Symbol { get; }
    }

    [DataContract]
    public class SpotInstrumentIdentity : ISpotInstrumentIdentity
    {
        [DataMember(Order = 1)]
        public string BrokerId { get; set; }

        [DataMember(Order = 2)]
        public string Symbol { get; set; }
    }
}
