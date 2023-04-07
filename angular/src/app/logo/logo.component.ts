import { Component } from '@angular/core';

@Component({
  selector: 'app-logo',
  template: `
    <a class="navbar-brand" routerLink="/" style="padding-left: 10px;">
      <!-- Change the img src -->
      <img
        src="assets/Nosa.png"
        alt="logo"
        width="100%"
        height="90px"
      />
    </a>
  `,
})
export class LogoComponent {}
