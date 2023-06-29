// <summary>
// <copyright file="ApiExceptionFilterAttribute.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.WebExceptionsPresenter;

/// <summary>
/// ApiException Filter Attribute Class.
/// </summary>
public class ApiExceptionFilterAttribute : TypeFilterAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiExceptionFilterAttribute"/> class.
    /// </summary>
    public ApiExceptionFilterAttribute()
         : base(typeof(CustomExceptionFilter))
    {
    }

    /// <summary>
    /// Custom Exception Class.
    /// </summary>
    private sealed class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IDictionary<Type, IExceptionHandler> exceptionHandlers;
        private readonly ILogger<ApiExceptionFilterAttribute> logger;
        private readonly IHostApplicationLifetime lifetime;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomExceptionFilter"/> class.
        /// </summary>
        /// <param name="logger">Logger Class.</param>
        /// <param name="lifetime">Life Time.</param>
        public CustomExceptionFilter(
            ILogger<ApiExceptionFilterAttribute> logger,
            IHostApplicationLifetime lifetime)
            =>
            (this.exceptionHandlers,
            this.logger,
            this.lifetime) =
            (new Dictionary<Type, IExceptionHandler>
            {
                { typeof(GeneralException), new GeneralExceptionHandler() },
                { typeof(ValidationException), new ValidationExceptionHandler() },
            },
            logger,
            lifetime);

        public void OnException(ExceptionContext context)
        {
            Type exceptionType = context.Exception.GetType();
            this.logger.LogError(context.Exception, context.Exception.Message);

            if (this.exceptionHandlers.ContainsKey(exceptionType))
            {
                this.exceptionHandlers[exceptionType].Handle(context);
            }
            else if (exceptionType == typeof(InvalidOperationException))
            {
                this.lifetime.StopApplication();
            }
            else
            {
                new ExceptionHandlerBase().SetResult(
                    context,
                    StatusCodes.Status500InternalServerError,
                    "Ha ocurrido un error al procesar la respuesta",
                    context.Exception.Message);
            }
        }
    }
}
