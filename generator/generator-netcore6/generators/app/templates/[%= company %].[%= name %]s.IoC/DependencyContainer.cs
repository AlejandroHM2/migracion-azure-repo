// <summary>
// <copyright file="DependencyContainer.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

using AutoMapper;
using [%= company %].[%= name %]s.Entities.Interfaces;
using [%= company %].[%= name %]s.Repositories.DataContext;
using [%= company %].[%= name %]s.Repositories.Repositories;
using [%= company %].[%= name %]s.UseCases.Common.Behavior;
using [%= company %].[%= name %]s.UseCases.Common.Mappings;
using [%= company %].[%= name %]s.UseCases.Create[%= name %];
using [%= company %].[%= name %]s.UseCases.Delete[%= name %];
using [%= company %].[%= name %]s.UseCases.GetAll[%= name %]s;
using [%= company %].[%= name %]s.UseCases.GetById[%= name %];
using [%= company %].[%= name %]s.UseCases.Update[%= name %];
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace [%= company %].[%= name %]s.IoC;

/// <summary>
/// Dependency Container Class.
/// </summary>
public static class DependencyContainer
{
    /// <summary>
    /// Dependency Injection Services.
    /// </summary>
    /// <param name="services">Service Collection to add Injection.</param>
    /// <param name="configuration">Configuration Settings.</param>
    /// <returns>Service Collection.</returns>
    public static IServiceCollection AddCleanArchitectureServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<I[%= name %]Repository, [%= name %]Repository>();
        services.AddScoped<I[%= name %]Repository, [%= name %]Repository>();
        services.AddScoped<I[%= name %]DetailRepository, [%= name %]DetailRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IDataBaseContext, [%= name %]Context>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Create[%= name %]Interactor).Assembly));
        services.AddValidatorsFromAssembly(typeof(Create[%= name %]Validator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Delete[%= name %]Interactor).Assembly));
        services.AddValidatorsFromAssembly(typeof(Delete[%= name %]Validator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Update[%= name %]Interactor).Assembly));
        services.AddValidatorsFromAssembly(typeof(Update[%= name %]Validator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAll[%= name %]Interactor).Assembly));
        services.AddValidatorsFromAssembly(typeof(GetAll[%= name %]Validator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Get[%= name %]ByIdInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(Get[%= name %]ByIdValidator).Assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        services.AddSingleton(new MapperConfiguration(mc => mc.AddProfile(new [%= name %]Profile())).CreateMapper());

        return services;
    }
}
