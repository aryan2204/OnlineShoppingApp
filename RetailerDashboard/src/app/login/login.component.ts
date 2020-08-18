import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import{Register} from '../models/register';
import {FormGroup,FormControl,Validators} from '@angular/forms';
import {LoginService} from '../services/loginService';
import { Login } from '../models/login';
import { Router } from '@angular/router';
import { SharedService } from '../services/sharedService';

@Component({
  selector: 'app-userlogin',
  templateUrl: './userlogin.component.html',
  styleUrls: ['./userlogin.component.css']
})
export class UserloginComponent implements OnInit {
  login:Login;
  result;
  userDetails;
  public service;
  showError;
  mylogin:FormGroup;
  constructor(private loginService:LoginService,private routes:Router,private sharedService:SharedService) 
  {
    this.service=sharedService;
    this.login=new Login();
    this.showError=false;
    this.mylogin=new FormGroup({
      Password:new FormControl(null,[Validators.required]),
     // email:new FormControl(null,[Validators.required,Validators.pattern('[a-zA-Z 0-9 @ .]*')]),
     Customer_EMail:new FormControl(null,[Validators.required,Validators.pattern('[a-zA-Z 0-9 @ .]*')]),
   // console.log(this.service.getuserData());
  })
} 
  public get Password(){
   return this.mylogin.get('Password');
  }

  public get Customer_EMail(){
    return this.mylogin.get('Customer_EMail');
  }

    userLogin()
    {
      
      if(this.mylogin.valid)
      {
        this.login.Email=this.Customer_EMail.value;
        this.login.Password=this.Password.value;
       this.loginService.login(this.login).subscribe((data)=>
      {
          this.result=data;
          console.log("In user login");
          if(this.result!=null)
          {
            
            this.service.setuserId(this.result);
            this.routes.navigate(["/userhome"]);
          }
       })
      }

       if(this.result==null)
       {
        this.showError=true;
       }
    }
  ngOnInit(): void {

    this.userDetails=this.service.getuserData();
    console.log(this.userDetails);
      this.login.Email=this.userDetails.Email;
      this.login.Password=this.userDetails.Password;
      

  }

}