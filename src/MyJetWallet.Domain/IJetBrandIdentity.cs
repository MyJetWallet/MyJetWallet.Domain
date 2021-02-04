using System.Runtime.Serialization;

namespace MyJetWallet.Domain
{
    public interface IJetBrandIdentity : IJetBrokerIdentity
    {
        string BrandId { get; }
    }

    [DataContract]
    public class JetBrandIdentity : JetBrokerIdentity, IJetBrandIdentity
    {
        public JetBrandIdentity()
        {
        }

        public JetBrandIdentity(string brokerId, string brandId) : base(brokerId)
        {
            BrandId = brandId;
        }

        [DataMember(Order = 2)]
        public string BrandId { get; set; }

        public JetBrandIdentity Create(IJetBrandIdentity id)
        {
            return new JetBrandIdentity()
            {
                BrokerId = id.BrokerId,
                BrandId = id.BrandId
            };
        }

        public JetBrandIdentity Create(string brokerId, string brandId)
        {
            return new JetBrandIdentity()
            {
                BrokerId = BrokerId,
                BrandId = brandId
            };
        }

        public override string ToString()
        {
            return $"{BrokerId}::{BrandId}";
        }
    }
}