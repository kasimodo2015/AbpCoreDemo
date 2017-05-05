using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AbpCoreDemo.Authorization;
using AbpCoreDemo.Authorization.Users;
using AbpCoreDemo.Users.Dto;
using Microsoft.AspNetCore.Identity;

namespace AbpCoreDemo.Users
{
    /* THIS IS JUST A SAMPLE. */
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserAppService : AbpCoreDemoAppServiceBase, IUserAppService
    {
        private readonly IRepository<User, long> _userRepository;
        private readonly IPermissionManager _permissionManager;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserAppService(
            IRepository<User, long> userRepository, 
            IPermissionManager permissionManager,
            IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _permissionManager = permissionManager;
            _passwordHasher = passwordHasher;
        }

        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await UserManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await UserManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async Task RemoveFromRole(long userId, string roleName)
        {
            var user = await UserManager.FindByIdAsync(userId.ToString());
            await UserManager.RemoveFromRoleAsync(user, roleName);
        }

        public async Task<ListResultDto<UserListDto>> GetUsers()
        {
            var users = await _userRepository.GetAllListAsync();

            return new ListResultDto<UserListDto>(
                ObjectMapper.Map<List<UserListDto>>(users)
                );
        }

        public async Task CreateUser(CreateUserInput input)
        {
            var user = ObjectMapper.Map<User>(input);

            user.TenantId = AbpSession.TenantId;
            user.Password = _passwordHasher.HashPassword(user, input.Password);
            user.IsEmailConfirmed = true;

            await UserManager.CreateAsync(user);
        }
    }
}