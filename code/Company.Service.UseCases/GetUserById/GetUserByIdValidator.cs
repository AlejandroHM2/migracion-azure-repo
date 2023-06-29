// <summary>
// <copyright file="GetUserByIdValidator.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

using FluentValidation;

namespace Company.Service.UseCases.GetByIdUser;

/// <summary>
/// Get User By Id Validator Class.
/// </summary>
public class GetUserByIdValidator : AbstractValidator<GetUserByIdInputPort>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetUserByIdValidator"/> class.
    /// </summary>
    public GetUserByIdValidator()
    {
        this.RuleFor(c => c.Data)
            .NotEmpty()
            .WithMessage("Debe proporcionar el identificador del usuario.");
    }
}
