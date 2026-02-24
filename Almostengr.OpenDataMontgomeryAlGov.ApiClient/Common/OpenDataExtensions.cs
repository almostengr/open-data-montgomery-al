using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

public static class OpenDataExtensions
{
    public static void AddOpenDataMontgomeryAlServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient();
        services.Configure<OpenDataMontgomerySettings>(configuration.GetSection(nameof(OpenDataMontgomerySettings)));
        services.AddTransient<ICodeViolationClient, CodeViolationClient>();
    }
}