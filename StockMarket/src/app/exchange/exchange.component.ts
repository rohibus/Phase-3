import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import { Exchange } from '../exchange';

@Component({
  selector: 'app-exchange',
  templateUrl: './exchange.component.html',
  styleUrls: ['./exchange.component.css']
})
export class ExchangeComponent implements OnInit 
{
  seid: number;
  stockExchange: string;
  brief:string;
  address:string;
  remarks:string;
  exch:Exchange;
  list:Exchange[];
  a:number;
  constructor(private service:ProductService,private router:Router) 
  { 
    this.exch=new Exchange();
  }

  ngOnInit(): void 
  {
  }

  addexchange()
  {
    this.exch.seid=this.seid;
    this.exch.address=this.address;
    this.exch.stockExchange=this.stockExchange;
    this.exch.remarks=this.remarks;
    this.exch.brief=this.brief;
    console.log(this.exch);
    this.service.addExchange(this.exch).subscribe(i=>{​​

      console.log(i.toString());
    }​​
    );

    this.router.navigateByUrl('/Login');
  }

  getexchange()
  {​​
    this.a=100;
    this.service.getallexchange().subscribe(i=>{​​
      this.list = i;
      console.log(this.list);
    }​​);
  }​​

}
