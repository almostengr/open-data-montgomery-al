namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

public abstract class Client
{
    public static string IncludeGeometry(bool include)
    {
        return include ? string.Empty : "&returnGeometry=false";
    }

    public static string IncludeCountOnly(bool include)
    {
        return include ? "&returnCountOnly=true" : string.Empty;
    }

    public static string IncludeIdsOnly(bool include)
    {
        return include ? "$returnIdsOnly=true" : string.Empty;
    }
}

public static class JoinOption{ 
    public const string And = "AND";
    public const string Or = "OR";
}
