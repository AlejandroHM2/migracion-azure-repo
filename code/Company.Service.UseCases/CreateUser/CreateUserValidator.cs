﻿// <summary>
// <copyright file="CreateUserValidator.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.CreateUser;

/// <summary>
/// Create User Validator Class.
/// </summary>
public class CreateUserValidator : AbstractValidator<CreateUserInputPort>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUserValidator"/> class.
    /// </summary>
    public CreateUserValidator()
    {
        this.RuleFor(c => c.Data.Email)
            .NotEmpty()
            .WithMessage("Debe proporcionar el email del usuario.");
        this.RuleFor(c => c.Data.UserType)
            .NotEmpty()
            .WithMessage("Debe proporcionar el tipo de usuario.");
        this.RuleFor(c => c.Data.LastName)
            .NotEmpty()
            .WithMessage("Debe proporcionar el appellido del usuario.");
        this.RuleFor(c => c.Data.Name)
            .NotEmpty()
            .MinimumLength(3)
            .WithMessage("Debe proporcionar el nombre del usuario.");
        this.RuleFor(c => c.Data.UserDetails)
            .Must(d => d.Any())
            .WithMessage("Deben especificarse los detalles del usuario.");
    }
}
