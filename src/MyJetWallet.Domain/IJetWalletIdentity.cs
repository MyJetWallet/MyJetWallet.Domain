using System.Runtime.Serialization;

namespace MyJetWallet.Domain
{
    public interface IJetWalletIdentity: IJetClientIdentity
    {
        string WalletId { get; }
    }

    [DataContract]
    public class JetWalletIdentity : IJetWalletIdentity
    {
        public JetWalletIdentity()
        {
        }

        public JetWalletIdentity(string brokerId, string brandId, string clientId, string walletId)
        {
            BrokerId = brokerId;
            BrandId = brandId;
            ClientId = clientId;
            WalletId = walletId;
        }

        [DataMember(Order = 1)] public string BrokerId { get; set; }
        [DataMember(Order = 2)] public string BrandId { get; set; }
        [DataMember(Order = 3)] public string ClientId { get; set; }
        [DataMember(Order = 4)] public string WalletId { get; set; }

        public override string ToString()
        {
            return $"{BrokerId}::{BrandId}::{ClientId}::{WalletId}";
        }
    }
}