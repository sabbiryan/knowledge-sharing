using Abp.AutoMapper;
using KS.Authorization.Users;

namespace KS.Shared.Dto
{
    [AutoMap(typeof(User))]
    public class SimpleUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
    }
}