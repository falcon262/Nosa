import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'Nosa.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'Nosa.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
