import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import {IPOentity} from '../ipoentity';import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ipodisplay',
  templateUrl: './ipodisplay.component.html',
  styleUrls: ['./ipodisplay.component.css']
})
export class IPOdisplayComponent implements OnInit 
{
  id: number;
        companyName: string;
        stockExchange: string;
        pricePerShare: number;
        totalNoOfShares: number;
        openDateTime: Date;
        remarks: string;
        ipo:IPOentity;
        list:IPOentity[];

  constructor(private service:ProductService,private router:Router) 
  { 
    this.ipo=new IPOentity();
  }

  ngOnInit(): void {
  }

  Displayipo()
  {​​
    
    this.service.displayipo().subscribe(i=>{​​
      this.list = i;
      console.log(this.list);
    }​​);
  }​​
}
