// <summary>
// <copyright file="UserWorker.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Backgrounds;

/// <summary>
/// UserWorker Class.
/// </summary>
public class UserWorker : BackgroundService
{
    private readonly ILogger<UserWorker> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserWorker"/> class.
    /// </summary>
    /// <param name="logger">Logger property.</param>
    public UserWorker(
        ILogger<UserWorker> logger)
        => this.logger = logger;

    /// <inheritdoc/>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        this.logger.LogDebug($"Example background is starting.");

        stoppingToken.Register(() =>
            this.logger.LogDebug($"Example background task is stopping."));

        await Task.Delay(5000, stoppingToken);

        await this.ProcessExecuteAsync(stoppingToken);
    }

    /// <summary>
    /// Method to execute process.
    /// </summary>
    /// <param name="stoppingToken">Cancellation Token.</param>
    /// <returns>Task.</returns>
    private async Task ProcessExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // TO DO
                this.logger.LogDebug("Example task doing background work.");
                await Task.Delay(10000, stoppingToken);
            }
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "{Message}", ex.Message);
        }
    }
}
