// <summary>
// <copyright file="Get[%= name %]ByIdValidator.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

using FluentValidation;

namespace [%= company %].[%= name %]s.UseCases.GetById[%= name %];

/// <summary>
/// Get [%= name %] By Id Validator Class.
/// </summary>
public class Get[%= name %]ByIdValidator : AbstractValidator<Get[%= name %]ByIdInputPort>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Get[%= name %]ByIdValidator"/> class.
    /// </summary>
    public Get[%= name %]ByIdValidator()
    {
        this.RuleFor(c => c.Data)
            .NotEmpty()
            .WithMessage("Debe proporcionar el identificador del usuario.");
    }
}
