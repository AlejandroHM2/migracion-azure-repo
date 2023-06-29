// <summary>
// <copyright file="GeneralException.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Exceptions;

/// <summary>
/// General Exception Class.
/// </summary>
public class GeneralException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralException"/> class.
    /// </summary>
    public GeneralException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralException"/> class.
    /// </summary>
    /// <param name="message">Exception Message.</param>
    public GeneralException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralException"/> class.
    /// </summary>
    /// <param name="message">Exception Message.</param>
    /// <param name="innerException">Inner Exception.</param>
    public GeneralException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeneralException"/> class.
    /// </summary>
    /// <param name="title">Title Exception.</param>
    /// <param name="detail">Detail Exception.</param>
    public GeneralException(string title, string detail)
        : base(title) => this.Detail = detail;

    /// <summary>
    /// Gets or sets property Detail.
    /// </summary>
    /// <value>
    /// Property Detail.
    /// </value>
    public string Detail { get; set; }
}
