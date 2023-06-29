// <summary>
// <copyright file="GeneralExceptionHandler.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.WebExceptionsPresenter;

/// <summary>
/// General Exception Handler Class.
/// </summary>
public class GeneralExceptionHandler : ExceptionHandlerBase, IExceptionHandler
{
    /// <inheritdoc/>
    public Task Handle(ExceptionContext context)
    {
        var exception = context.Exception as GeneralException;
        return this.SetResult(
            context,
            StatusCodes.Status500InternalServerError,
            exception.Message,
            exception.Detail);
    }
}
