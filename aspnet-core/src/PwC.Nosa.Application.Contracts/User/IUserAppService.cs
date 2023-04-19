using PwC.Nosa.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace PwC.Nosa.User
{
    public interface IUserAppService : IApplicationService
    {
        Task<UserInfoDto> GetCurrentUserDetails();

        Task<string> GetUserSettingsByToken(string token);

        Task UpdateUserLosAsync(Guid id, string los);

    }
}
