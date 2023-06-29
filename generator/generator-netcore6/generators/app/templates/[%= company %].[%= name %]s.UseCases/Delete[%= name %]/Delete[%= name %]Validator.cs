// <summary>
// <copyright file="Delete[%= name %]Validator.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Delete[%= name %];

/// <summary>
/// Delete [%= name %] Validator Class.
/// </summary>
public class Delete[%= name %]Validator : AbstractValidator<Delete[%= name %]InputPort>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Delete[%= name %]Validator"/> class.
    /// </summary>
    public Delete[%= name %]Validator()
    {
        this.RuleFor(c => c.Data)
            .NotEmpty()
            .WithMessage("Debe proporcionar el identificador del usuario.");
    }
}
