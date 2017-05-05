using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreDemo.Authorization.Accounts.Dto;

namespace AbpCoreDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
