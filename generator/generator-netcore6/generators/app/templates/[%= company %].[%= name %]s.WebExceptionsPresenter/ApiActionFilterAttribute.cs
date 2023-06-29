// <summary>
// <copyright file="ApiActionFilterAttribute.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.WebExceptionsPresenter;

/// <summary>
/// ApiAction Filter Attribute Class.
/// </summary>
public class ApiActionFilterAttribute : TypeFilterAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiActionFilterAttribute"/> class.
    /// </summary>
    public ApiActionFilterAttribute()
         : base(typeof(CustomActionFilter))
    {
    }

    /// <summary>
    /// Custom Action Filter Class.
    /// </summary>
    private sealed class CustomActionFilter : IActionFilter
    {
        private readonly ILogger<ApiActionFilterAttribute> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomActionFilter"/> class.
        /// </summary>
        /// <param name="logger">Logger Class.</param>
        public CustomActionFilter(ILogger<ApiActionFilterAttribute> logger)
            => this.logger = logger;

        public void OnActionExecuting(ActionExecutingContext context)
            => this.Log("OnActionExecuting", context.RouteData);

        public void OnActionExecuted(ActionExecutedContext context)
            => this.Log("OnActionExecuted", context.RouteData);

        private void Log(string methodName, RouteData routeData)
        {
            try
            {
                System.Text.StringBuilder mensaje = new System.Text.StringBuilder();
                mensaje.Append($"{methodName}: [");

                foreach (var item in routeData.Values)
                {
                    mensaje.Append($"{item.Key}: {item.Value}, ");
                }

                mensaje.Length -= 2;
                mensaje.Append("]");

                this.logger.LogInformation(mensaje.ToString());
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, ex.Message);
            }
        }
    }
}
