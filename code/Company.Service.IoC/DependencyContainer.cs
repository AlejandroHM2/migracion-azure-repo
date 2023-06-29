// <summary>
// <copyright file="DependencyContainer.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

using AutoMapper;
using Company.Service.Entities.Interfaces;
using Company.Service.Repositories.DataContext;
using Company.Service.Repositories.Repositories;
using Company.Service.UseCases.Common.Behavior;
using Company.Service.UseCases.Common.Mappings;
using Company.Service.UseCases.CreateUser;
using Company.Service.UseCases.DeleteUser;
using Company.Service.UseCases.GetAllUsers;
using Company.Service.UseCases.GetByIdUser;
using Company.Service.UseCases.UpdateUser;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Company.Service.IoC;

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
        services.AddScoped<IDataBaseContext, UserContext>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserDetailRepository, UserDetailRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateUserInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(CreateUserValidator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DeleteUserInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(DeleteUserValidator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UpdateUserInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(UpdateUserValidator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllUserInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(GetAllUserValidator).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetUserByIdInteractor).Assembly));
        services.AddValidatorsFromAssembly(typeof(GetUserByIdValidator).Assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        services.AddSingleton(new MapperConfiguration(mc => mc.AddProfile(new UserProfile())).CreateMapper());

        return services;
    }
}
