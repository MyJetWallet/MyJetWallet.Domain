using System.Runtime.Serialization;

namespace MyJetWallet.Domain
{
    public interface IJetClientIdentity: IJetBrandIdentity
    {
        string ClientId { get; }
    }

    [DataContract]
    public class JetClientIdentity : IJetClientIdentity
    {
        public JetClientIdentity()
        {
        }

        public JetClientIdentity(string brokerId, string brandId, string clientId)
        {
            BrokerId = brokerId;
            BrandId  = brandId;
            ClientId = clientId;
        }

        [DataMember(Order = 1)] public string BrokerId { get; set; }
        [DataMember(Order = 2)] public string BrandId { get; set; }
        [DataMember(Order = 3)] public string ClientId { get; set; }

        public override string ToString()
        {
            return $"{BrokerId}::{BrandId}::{ClientId}";
        }

        
    }
}