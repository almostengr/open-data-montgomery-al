namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

public interface ICodeViolationClient
{
    Task<CodeViolationCountResource> GetCountAsync();
}

// https://gis.montgomeryal.gov/server/rest/services/HostedDatasets/Code_Violations/FeatureServer/0/query?outFields=*&where=1%3D1