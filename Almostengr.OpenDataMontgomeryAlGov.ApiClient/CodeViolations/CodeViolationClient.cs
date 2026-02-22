using Almostengr.Common.Infrastructure;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

public class CodeViolationClient : Client, ICodeViolationClient
{
    private readonly HttpClient _httpClient;
    private readonly OpenDataMontgomerySettings _settings;
    private const string BASE_URL = "Code_Violations/FeatureServer/0/query?where=1%3D1&outFields=*&outSR=4326&f=json";

    public CodeViolationClient(
        HttpClient httpClient,
        OpenDataMontgomerySettings settings
    )
    {
        _settings = settings;
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(_settings.EndpointUrl);
    }

    public async Task<CodeViolationCountResource> GetCountAsync()
    {
        string route = $"{BASE_URL}&{IncludeCountOnly(true)}";
        CodeViolationCountResource response = await _httpClient.GetAsync<CodeViolationCountResource>(route);
        return response;
    }
}


// https://gis.montgomeryal.gov/server/rest/services/HostedDatasets/Code_Violations/FeatureServer/0/query?outFields=*&where=1%3D1
