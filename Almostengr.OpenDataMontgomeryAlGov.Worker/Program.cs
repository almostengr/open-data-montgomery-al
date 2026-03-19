using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;
using Almostengr.OpenDataMontgomeryAlGov.Worker;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddOpenDataMontgomeryAlServices(builder.Configuration);

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
