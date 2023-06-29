// <summary>
// <copyright file="ValidationBehavior.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.Common.Behavior;

/// <summary>
/// Validation Behavior Class.
/// </summary>
/// <typeparam name="TRequest">Type Of Request.</typeparam>
/// <typeparam name="TResponse">Type of Response.</typeparam>
public class ValidationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> validators;

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationBehavior{TRequest, TResponse}"/> class.
    /// </summary>
    /// <param name="validators">List of Validators.</param>
    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        => this.validators = validators;

    /// <inheritdoc/>
    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var failures = this.validators
            .Select(v => v.Validate(request))
            .SelectMany(r => r.Errors)
            .Where(f => f != null)
            .ToList();
        if (failures.Any())
        {
            throw new ValidationException(failures);
        }

        return next();
    }
}
