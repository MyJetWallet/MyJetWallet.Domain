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
        [DataMember(Order = 3)]
        public string ClientId { get; set; }
    }
}