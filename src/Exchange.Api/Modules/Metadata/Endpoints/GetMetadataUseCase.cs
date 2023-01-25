﻿using Exchange.Api.Modules.Metadata.Core;
using Exchange.Core.Ports;

namespace Exchange.Api.Modules.Metadata.Endpoints;

public class GetMetadataUseCase : IGetMetadataUseCase
{
    private readonly IExchangeRepository _repository;
    
    public GetMetadataUseCase(IExchangeRepository repository)
    {
        _repository = repository;
    }

    public async Task<CryptocurrencyMetadata?> Handle(string cryptoCurrencySymbol, CancellationToken cancellationToken = default)
    {
        return await _repository.GetMetadataAsync(cryptoCurrencySymbol, cancellationToken);
    }
}