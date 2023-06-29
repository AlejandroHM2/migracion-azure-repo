// <summary>
// <copyright file="[%= name %]Profile.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Common.Mappings;

/// <summary>
/// [%= name %] Profile Class.
/// </summary>
public class [%= name %]Profile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="[%= name %]Profile"/> class.
    /// </summary>
    public [%= name %]Profile()
    {
        this.CreateMap<[%= name %], [%= name %]Dto>();
        this.CreateMap<Create[%= name %]Dto, [%= name %]>();
        this.CreateMap<[%= name %]DetailDto, [%= name %]Detail>();
        this.CreateMap<Update[%= name %]Dto, [%= name %]>();
    }
}
