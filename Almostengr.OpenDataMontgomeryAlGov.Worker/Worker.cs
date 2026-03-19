using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

namespace Almostengr.OpenDataMontgomeryAlGov.Worker;

public class Worker(
    ILogger<Worker> logger,
    ICodeViolationClient codeViolationClient
    ) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // while (!stoppingToken.IsCancellationRequested)
        // {
        //     if (logger.IsEnabled(LogLevel.Information))
        //     {
        //         logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        //     }
        //     await Task.Delay(1000, stoppingToken);
        // }

        logger.LogInformation("Starting tasks");

        // await codeViolationClient.GetCountAsync()

        logger.LogInformation("Completed tasks.");
    }
}
