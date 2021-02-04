using System.Runtime.Serialization;

namespace MyJetWallet.Domain
{
    public interface IJetWalletIdentity: IJetClientIdentity
    {
        string WalletId { get; }
    }

    [DataContract]
    public class JetWalletIdentity : JetClientIdentity, IJetWalletIdentity
    {
        public JetWalletIdentity()
        {
        }

        public JetWalletIdentity(string brokerId, string brandId, string clientId, string walletId) : base(brokerId, brandId, clientId)
        {
            WalletId = walletId;
        }

        [DataMember(Order = 4)]
        public string WalletId { get; set; }

        public override string ToString()
        {
            return $"{BrokerId}::{BrandId}::{ClientId}::{WalletId}";
        }

    }
}