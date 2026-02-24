using Microsoft.Extensions.Options;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common.Clients;

public abstract class Client
{
    protected readonly OpenDataMontgomerySettings _appSettings;
    protected readonly HttpClient _httpClient;

    public Client(HttpClient httpClient, IOptions<OpenDataMontgomerySettings> options)
    {
        _appSettings = options.Value;

        _httpClient = httpClient;
        _httpClient.Timeout = TimeSpan.FromSeconds(_appSettings.TimeOut);

        if (!string.IsNullOrWhiteSpace(_appSettings.ApiKey) && !string.IsNullOrWhiteSpace(_appSettings.ApiToken))
        {
            _httpClient.DefaultRequestHeaders.Add(_appSettings.ApiKey, _appSettings.ApiToken);
        }
    }

    protected string BuildRoute(string baseUrl, UrlQueryBuilder urlQuery)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(baseUrl);
        
        return $"{baseUrl}?f=json&outFields=*&outSR=4326&{urlQuery.Build()}";
    }
}
