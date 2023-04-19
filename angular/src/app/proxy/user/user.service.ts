import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { UserInfoDto } from '../user-dtos/models';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  apiName = 'Default';
  

  getCurrentUserDetails = () =>
    this.restService.request<any, UserInfoDto>({
      method: 'GET',
      url: '/api/app/user/current-user-details',
    },
    { apiName: this.apiName });
  

  getUserSettingsByTokenByToken = (token: string) =>
    this.restService.request<any, string>({
      method: 'GET',
      responseType: 'text',
      url: '/api/app/user/user-settings-by-token',
      params: { token },
    },
    { apiName: this.apiName });
  

  updateUserLos = (id: string, los: string) =>
    this.restService.request<any, void>({
      method: 'PUT',
      url: `/api/app/user/${id}/user-los`,
      params: { los },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
