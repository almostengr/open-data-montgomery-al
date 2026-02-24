using Almostengr.Common.Infrastructure;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations.Resources;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common.Clients;
using Microsoft.Extensions.Options;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

public class CodeViolationClient : Client, ICodeViolationClient
{
    private const string BASE_URL = "Code_Violations/FeatureServer/0/query";

    public CodeViolationClient(
        HttpClient httpClient, IOptions<OpenDataMontgomerySettings> options
    ) : base(httpClient, options)
    {
    }

    public async Task<CodeViolationCountResource> GetCountAsync(UrlQueryBuilder urlQuery)
    {
        string route = BuildRoute(BASE_URL, urlQuery.ReturnCountOnly());
        CodeViolationCountResource response = await _httpClient.GetAsync<CodeViolationCountResource>(route);
        return response;
    }

    public async Task<CodeViolationIdsResource> GetIdsAsync(UrlQueryBuilder urlQuery)
    {
        string route = BuildRoute(BASE_URL, urlQuery.ReturnIdsOnly());
        CodeViolationIdsResource response = await _httpClient.GetAsync<CodeViolationIdsResource>(route);
        return response;
    }
}
