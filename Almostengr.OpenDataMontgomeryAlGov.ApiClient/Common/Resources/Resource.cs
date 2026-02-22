namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

public abstract class Resource
{
}

public abstract class CountResource : Resource
{
    public int Count { get; set; }
}