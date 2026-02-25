using Moq;
using Moq.Protected;
using System.Net;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Tests;

public class CodeViolationClientTests : Tests
{
    public CodeViolationClientTests() : base()
    {
    }

    [Fact]
    public async Task GetCountAsync_ReturnsValidCount()
    {
        // Arrange
        var query = new UrlQueryBuilder();
        var json = "{ \"count\": 150 }";
        SetupMockResponse("returnCountOnly=true", json);

        var client = new CodeViolationClient(_httpClient, _options);

        // Act
        var result = await client.GetCountAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(150, result.Count);
    }

    [Fact]
    public async Task GetIdsAsync_ReturnsListOfIds()
    {
        // Arrange
        var query = new UrlQueryBuilder();
        var json = "{ \"objectIds\": [101, 102, 103] }";
        SetupMockResponse("returnIdsOnly=true", json);

        var client = new CodeViolationClient(_httpClient, _options);

        // Act
        var result = await client.GetIdsAsync(query);

        // Assert
        Assert.NotNull(result);
        Assert.Contains(101, result.ObjectIds);
        Assert.Equal(3, result.ObjectIds.Count);
    }

    [Fact]
    public async Task GetCountAsync_ThrowsException_OnApiError()
    {
        // Arrange
        _handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.NotFound });

        var client = new CodeViolationClient(_httpClient, _options);

        // Act & Assert
        await Assert.ThrowsAsync<HttpRequestException>(() => client.GetCountAsync(new UrlQueryBuilder()));
    }
}
