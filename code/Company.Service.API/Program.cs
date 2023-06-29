// <summary>
// <copyright file="Program.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

const string APP_NAME = "API User";

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add Placeholder
    builder.AddPlaceholderResolver();

    // Add Serilog
    builder.Host.UseSerilog();

    Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Debug)
            .MinimumLevel.Override("System", LogEventLevel.Debug)
            .WriteTo.Seq(builder.Configuration.GetSection("AppConfig:SeqUrl").Value)
            .WriteTo.Console()
            .CreateLogger();

    Log.Information($"{APP_NAME} service starting.");

    // Add services to the container.
    builder.Services.AddControllers(opt =>
    {
        opt.Filters.Add(new ApiExceptionFilterAttribute());
        opt.Filters.Add(new ApiActionFilterAttribute());
    });

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Add Connection String Config
    builder.Services.Configure<EndpointSettings>(builder.Configuration.GetSection("AppConfig"));

    builder.Services.AddCleanArchitectureServices(builder.Configuration);

    // Add Background Service
    builder.Services.AddHostedService<UserWorker>();

    // Add Redis Cache
    builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = builder.Configuration.GetSection("AppConfig:RedisCacheUrl").Value; });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, $"{APP_NAME} service failed to start.");
}
finally
{
    Log.CloseAndFlush();
}