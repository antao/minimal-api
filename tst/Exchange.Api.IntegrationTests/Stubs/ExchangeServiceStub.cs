﻿using Exchange.Domain;
using Exchange.Domain.Interfaces;

namespace Exchange.Api.IntegrationTests.Stubs;

internal class ExchangeServiceStub : IExchangeService
{
    public Task<IEnumerable<Metadata>?> GetInfoAsync(string[] symbols, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<CryptoCurrencyQuote> GetQuotesAsync(string cryptoCurrencyCode, CancellationToken cancellationToken = default)
    {
        var fakeQuotes = new List<Quote>
        {
            new("USD", 1),
            new("BLR", 2),
            new("EUR", 3),
            new("GBP", 5),
            new("AUD", 8),
        };
            
        return await Task.FromResult(new CryptoCurrencyQuote("TST", fakeQuotes));
    }
}