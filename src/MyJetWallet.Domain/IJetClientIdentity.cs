using System.Runtime.Serialization;

namespace MyJetWallet.Domain
{
    public interface IJetClientIdentity: IJetBrandIdentity
    {
        string ClientId { get; }
    }

    [DataContract]
    public class JetClientIdentity : JetBrandIdentity, IJetClientIdentity
    {
        public JetClientIdentity()
        {
        }

        public JetClientIdentity(string brokerId, string brandId, string clientId) : base(brokerId, brandId)
        {
            ClientId = clientId;
        }

        [DataMember(Order = 3)]
        public string ClientId { get; set; }

        public override string ToString()
        {
            return $"{BrokerId}::{BrandId}::{ClientId}";
        }
    }
}