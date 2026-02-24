namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common.Resources;

public abstract class IdsResource : Resource
{
    public List<int> ObjectIds { get; set; } = new();
}
