// <summary>
// <copyright file="ValidationExceptionHandler.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.WebExceptionsPresenter;

/// <summary>
/// Validation Exception Handler Class.
/// </summary>
public class ValidationExceptionHandler : ExceptionHandlerBase, IExceptionHandler
{
    /// <inheritdoc/>
    public Task Handle(ExceptionContext context)
    {
        var exception = context.Exception as ValidationException;

        StringBuilder builder = new ();
        foreach (var failure in exception.Errors)
        {
            builder.AppendLine(string.Format(
                "Propiedad: {0}. Error: {1}",
                failure.PropertyName,
                failure.ErrorMessage));
        }

        return this.SetResult(
            context,
            StatusCodes.Status400BadRequest,
            "Error en los datos de entrada",
            builder.ToString());
    }
}
