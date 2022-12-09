﻿using System.Text.Json.Serialization;

namespace Exchange.Infrastructure.Services;

public sealed class ExchangeRateLiveResponse
{
    [JsonPropertyName("rates")] 
    public Dictionary<string, decimal>? Rates { set; get; }

    [JsonPropertyName("base")]
    public string? BaseCurrency { set; get; }

    [JsonPropertyName("timestamp")] 
    public long Timestamp { get; set; }
}