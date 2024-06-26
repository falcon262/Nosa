﻿using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using PwC.Nosa.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Identity;
using System.Text.Json.Serialization;
using System.Text.Json;
using Volo.Abp.DependencyInjection;

namespace PwC.Nosa.User
{
    public class UserAppService : NosaAppService, IUserAppService, ITransientDependency
    {
        private readonly IdentityUserAppService _identityUserAppService;
        
        private readonly IIdentityUserRepository _identityUserRepository;

        private readonly IConfiguration _configuration;

        public UserAppService(IdentityUserAppService identityUserAppService, IIdentityUserRepository identityUserRepository)
        {
            _identityUserAppService = identityUserAppService;
            _identityUserRepository = identityUserRepository;   
        }

        public async Task<UserInfoDto> GetCurrentUserDetails()
        {
            var currentUser = await _identityUserAppService.GetAsync((Guid)CurrentUser.Id);

            UserInfoDto user = new UserInfoDto
            {
                Id = currentUser.Id,
                Email = currentUser.Email,
                FirstName = currentUser.Name,
                LastName = currentUser.Surname,
                PhoneNumber = currentUser.PhoneNumber,
                LOS = currentUser.ExtraProperties.GetOrDefault("LOS") != null ? currentUser.ExtraProperties.GetOrDefault("LOS").ToString() : " ",
            };

            return user;
        }

        public async Task<string> GetUserSettingsByToken(string token)
        {
            var result = "";

            using var httpClient = new HttpClient();
            httpClient.SetBearerToken(token);

            var url = "https://localhost:44335/api/app/user/current-user-details";

            var responseMessage = await httpClient.GetAsync(url);

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseString = await responseMessage.Content.ReadAsStringAsync();
                result = result + responseString;
            }

            return result;
        }

        public async Task UpdateUserLosAsync(Guid id, string los)
        {
            var user = await _identityUserRepository.GetAsync(id);


            if (user.ExtraProperties.ContainsKey("LOS"))
            {
                user.ExtraProperties["LOS"] = los;
            }

            await _identityUserRepository.UpdateAsync(user);
            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }
}
