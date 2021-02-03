namespace MyJetWallet.Domain
{
    public interface IJetWalletIdentity: IJetClientIdentity
    {
        string WalletId { get; }
    }
}