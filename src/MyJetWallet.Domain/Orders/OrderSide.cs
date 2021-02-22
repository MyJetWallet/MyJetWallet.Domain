using System.Text.Json.Serialization;
// ReSharper disable UnusedMember.Global

namespace MyJetWallet.Domain.Orders
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderSide
    {
        UnknownOrderSide,
        Buy,
        Sell,
    }
}