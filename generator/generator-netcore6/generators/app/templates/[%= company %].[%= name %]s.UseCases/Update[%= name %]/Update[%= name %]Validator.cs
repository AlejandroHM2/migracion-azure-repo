﻿// <summary>
// <copyright file="Update[%= name %]Validator.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Update[%= name %];

/// <summary>
/// Update [%= name %] Validator Class.
/// </summary>
public class Update[%= name %]Validator : AbstractValidator<Update[%= name %]InputPort>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Update[%= name %]Validator"/> class.
    /// </summary>
    public Update[%= name %]Validator()
    {
        this.RuleFor(c => c.Data.Email)
            .NotEmpty()
            .WithMessage("Debe proporcionar el email del usuario.");
        this.RuleFor(c => c.Data.[%= name %]Type)
            .NotEmpty()
            .WithMessage("Debe proporcionar el tipo de usuario.");
        this.RuleFor(c => c.Data.LastName)
            .NotEmpty()
            .WithMessage("Debe proporcionar el appellido del usuario.");
        this.RuleFor(c => c.Data.Name)
            .NotEmpty()
            .MinimumLength(3)
            .WithMessage("Debe proporcionar el nombre del usuario.");
        this.RuleFor(c => c.Data.[%= name %]Details)
            .Must(d => d.Any())
            .WithMessage("Deben especificarse los detalles del usuario.");
    }
}
