using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreDemo.Sessions.Dto;

namespace AbpCoreDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
