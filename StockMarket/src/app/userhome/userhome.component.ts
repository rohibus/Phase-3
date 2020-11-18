import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userhome',
  templateUrl: './userhome.component.html',
  styleUrls: ['./userhome.component.css']
})
export class UserhomeComponent implements OnInit {
  username:string;
  usertype:string;

  constructor(private service:ProductService,private router:Router) 
  { 
    this.username=this.service.username;
    this.usertype=this.service.usertype;
  }

  ngOnInit(): void {
  }

}
