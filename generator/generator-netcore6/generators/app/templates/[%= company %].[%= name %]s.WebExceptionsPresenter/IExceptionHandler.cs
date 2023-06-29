// <summary>
// <copyright file="IExceptionHandler.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.WebExceptionsPresenter;

/// <summary>
/// Exception Handler Interface.
/// </summary>
public interface IExceptionHandler
{
    /// <summary>
    /// Exception Handler.
    /// </summary>
    /// <param name="context">Exception Context.</param>
    /// <returns>Task.</returns>
    Task Handle(ExceptionContext context);
}
