import { Component, OnInit } from '@angular/core';
import {User} from '../user';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  list:any;
  id:number;
	username:string;
	password:string;
	userType:string;
	email:string;
	mobile:number;
  confirmed:number;
  user:User;

  constructor(private service:ProductService,private router:Router) 
  {
    
  }

  ngOnInit(): void {
  }
  
  Login()

   {​​
      this.user = new User();
     this.user.Username = this.username;
     this.user.Password = this.password;
     this.user.UserType = this.userType;
     console.log(this.user);
     if(this.userType == "User")
     {​​
      this.service.userLogin(this.user).subscribe(i=>{​​console.log(i.toString());
        if(i.toString()=="User logged in")
        {
          this.service.username=this.username;
          this.service.usertype=this.userType;
          this.router.navigateByUrl('userlogin');
        }   
      }​​); 
     }​​

     else if(this.userType == "Admin")

     {​​

      this.service.adminLogin(this.user).subscribe(i=>{​​

        console.log(i.toString());
        if(i.toString()=="Admin logged in")
        {
          this.service.username=this.username;
          this.service.usertype=this.userType;
          this.router.navigateByUrl('adminlogin');
        }
        
      }​​)
      
      

     }​​
     else
     console.log("Log in failed");
   }

}
