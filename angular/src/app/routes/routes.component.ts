import { Component, HostBinding, OnInit } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';

@Component({
  selector: 'app-routes',
  templateUrl: 'routes.component.html',
})
export class RoutesComponent implements OnInit{

  constructor(private oAuthService: OAuthService) {}

  accessToken = " ";

  ngOnInit(): void {
      this.accessToken = this.oAuthService.getAccessToken();
  }

  @HostBinding('class.mx-auto')
  marginAuto = true;

  get smallScreen() {
    return window.innerWidth < 992;
  }
}
