using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations.Resources;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

public interface ICodeViolationClient
{
    Task<CodeViolationCountResource> GetCountAsync(UrlQueryBuilder urlQuery);
    Task<CodeViolationIdsResource> GetIdsAsync(UrlQueryBuilder urlQuery);
}