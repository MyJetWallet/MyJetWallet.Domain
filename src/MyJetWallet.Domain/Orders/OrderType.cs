﻿// ReSharper disable UnusedMember.Global

using System.Text.Json.Serialization;

namespace MyJetWallet.Domain.Orders
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderType
    {
        UnknownOrderType,
        Market,
        Limit,
        StopLimit,
    }
}