using System.Collections.Generic;
using KS.Roles.Dto;
using KS.Users.Dto;

namespace KS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
