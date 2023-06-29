// <summary>
// <copyright file="ExceptionHandlerBase.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.WebExceptionsPresenter;

/// <summary>
/// Exception Handler Base Class.
/// </summary>
public class ExceptionHandlerBase
{
    private readonly Dictionary<int, string> types = new Dictionary<int, string>
    {
        {
            StatusCodes.Status500InternalServerError,
            "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1"
        },
        {
            StatusCodes.Status400BadRequest,
            "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4"
        },
    };

    /// <summary>
    /// Set Result Exception.
    /// </summary>
    /// <param name="context">Exception Context.</param>
    /// <param name="status">Status.</param>
    /// <param name="title">Title Exception.</param>
    /// <param name="detail">Detail Exception.</param>
    /// <returns>Task.</returns>
    public Task SetResult(
        ExceptionContext context, int? status, string title, string detail)
    {
        ProblemDetails detail1 = new ()
        {
            Status = status,
            Title = title,
            Type = this.types.ContainsKey(status.Value) ?
            this.types[status.Value] : string.Empty,
            Detail = detail,
        };
        context.Result = new ObjectResult(detail1)
        {
            StatusCode = status,
        };
        context.ExceptionHandled = true;
        return Task.CompletedTask;
    }
}
