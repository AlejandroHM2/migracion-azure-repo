// <summary>
// <copyright file="UserProfile.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.Common.Mappings;

/// <summary>
/// User Profile Class.
/// </summary>
public class UserProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserProfile"/> class.
    /// </summary>
    public UserProfile()
    {
        this.CreateMap<User, UserDto>();
        this.CreateMap<CreateUserDto, User>();
        this.CreateMap<UserDetailDto, UserDetail>();
        this.CreateMap<UpdateUserDto, User>();
    }
}
