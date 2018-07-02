using System.Threading.Tasks;
using Abp.Application.Services;
using KS.Sessions.Dto;

namespace KS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
