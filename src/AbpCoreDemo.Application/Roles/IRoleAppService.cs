using System.Threading.Tasks;
using Abp.Application.Services;
using AbpCoreDemo.Roles.Dto;

namespace AbpCoreDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
