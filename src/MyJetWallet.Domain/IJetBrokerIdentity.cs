using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace MyJetWallet.Domain
{
    [UsedImplicitly]
    public interface IJetBrokerIdentity
    {
        string BrokerId { get; }
    }

    [DataContract]
    public class JetBrokerIdentity : IJetBrokerIdentity
    {
        [DataMember(Order = 1)]
        public string BrokerId { get; set; }

        public JetBrokerIdentity Create(IJetBrokerIdentity id)
        {
            return new JetBrokerIdentity()
            {
                BrokerId = id.BrokerId
            };
        }

        public JetBrokerIdentity Create(string brokerId)
        {
            return new JetBrokerIdentity()
            {
                BrokerId = BrokerId
            };
        }
    }
}
