using Moq;
using Moq.Protected;
using System.Net;
using Microsoft.Extensions.Options;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Tests;

public abstract class Tests
{
    protected readonly Mock<HttpMessageHandler> _handlerMock;
    protected readonly HttpClient _httpClient;
    protected readonly IOptions<OpenDataMontgomerySettings> _options;

    protected Tests()
    {
        _handlerMock = new Mock<HttpMessageHandler>();
        _httpClient = new HttpClient(_handlerMock.Object)
        {
            BaseAddress = new Uri("https://api.montgomery.gov/")
        };

        _options = Options.Create(new OpenDataMontgomerySettings());
    }

    protected void SetupMockResponse(string expectedUrl, string jsonResponse)
    {
        _handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri.ToString().Contains(expectedUrl)),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(jsonResponse),
            });
    }
}