// ReSharper disable UnusedMember.Global

namespace MyJetWallet.Domain.Orders
{
    public enum OrderStatus
    {
        UnknownStatus,
        Placed,
        Matched,
        Cancelled
    }
}