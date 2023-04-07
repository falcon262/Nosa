import { Component, OnInit } from '@angular/core';
import {ReplaceableComponentsService} from '@abp/ng.core'
import { LogoComponent } from './logo/logo.component';
import { RoutesComponent } from './routes/routes.component';
import { NavItemsComponent } from './nav-items/nav-items.component';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
    <abp-gdpr-cookie-consent></abp-gdpr-cookie-consent>
  `,
})
export class AppComponent implements OnInit {
  constructor(private replaceableComponents: ReplaceableComponentsService) {} // injected ReplaceableComponentsService

  ngOnInit() {

    this.replaceableComponents.add({
        component: LogoComponent,
        key: eThemeBasicComponents.Logo,
      });

    this.replaceableComponents.add({
        component: RoutesComponent,
        key: eThemeBasicComponents.Routes,
    });

    this.replaceableComponents.add({
      component: NavItemsComponent,
      key: eThemeBasicComponents.NavItems,
    });
  }

}
