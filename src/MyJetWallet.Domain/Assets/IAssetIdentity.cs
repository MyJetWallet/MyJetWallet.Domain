using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Assets
{
    public interface IAssetIdentity : IJetBrokerIdentity
    {
        /// <summary>
        /// Uniq ID of asset into the broker 
        /// </summary>
        string Symbol { get; }
    }

    [DataContract]
    public class AssetIdentity : IAssetIdentity
    {
        [DataMember(Order = 1)] public string BrokerId { get; set; }
        [DataMember(Order = 2)] public string Symbol { get; set; }
    }
}