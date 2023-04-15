import { Component, OnInit } from '@angular/core';
import { UserService } from '@proxy/user';
import { UserInfoDto } from '@proxy/user-dtos';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit{

  constructor(private _userService: UserService) {
    
  }

  userName = " ";

  currentUser: UserInfoDto;

  ngOnInit(): void {
      this.getUserDetails();
  }

  getUserDetails(): void {
    this._userService.getCurrentUserDetails().subscribe(result =>{
      this.currentUser = result;
      this.userName = this.currentUser.firstName?.charAt(0).toUpperCase() + this.currentUser.firstName?.slice(1);
      console.log(this.currentUser);
    })
  }

}
