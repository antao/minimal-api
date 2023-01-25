﻿using Exchange.Api.Modules.Metadata.Core;

namespace Exchange.Core.Ports;

public interface IGetMetadataUseCase
{
    Task<CryptocurrencyMetadata?> Handle(string cryptoCurrencySymbol, CancellationToken cancellationToken = default);
}