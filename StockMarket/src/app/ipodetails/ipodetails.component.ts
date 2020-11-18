import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import {IPOentity} from '../ipoentity';

@Component({
  selector: 'app-ipodetails',
  templateUrl: './ipodetails.component.html',
  styleUrls: ['./ipodetails.component.css']
})
export class IPOdetailsComponent implements OnInit 
{
        id: number;
        companyName: string;
        stockExchange: string;
        pricePerShare: number;
        totalNoOfShares: number;
        openDateTime: Date;
        remarks: string;
        ipo:IPOentity;

  constructor(private service:ProductService,private router:Router) 
  { 
    this.ipo=new IPOentity();
  }

  ngOnInit(): void 
  {
  }

  addIPO()
  {
    this.ipo.id=this.id;
    this.ipo.companyName=this.companyName;
    this.ipo.stockExchange=this.stockExchange;
    this.ipo.pricePerShare=this.pricePerShare;
    this.ipo.totalNoOfShares=this.totalNoOfShares;
    this.ipo.openDateTime=this.openDateTime;
    this.ipo.remarks=this.remarks;
    console.log(this.ipo);

    this.service.addIPO(this.ipo).subscribe(i=>{​​

      console.log(i.toString());}​​);

      this.router.navigateByUrl('/ipodisplay');
      
  }

  

}
