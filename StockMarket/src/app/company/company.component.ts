import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router } from '@angular/router';
import { Company } from '../company';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit 
{
companyId  : number;
companyName :string;  
turnover : number;  
ceo : string;  
boardOfDirectors : string;  
listedInStockExchange : number;  
sector : string;  
briefWriteup : string;  
companyStockCode : number;
comp:Company;



  constructor(private service:ProductService,private router:Router) 
  { 
    this.comp=new Company();
  }

  ngOnInit(): void {
  }

  addcompany()
  {​​
    this.comp.companyId = this.companyId;
    this.comp.companyName = this.companyName;
    this.comp.turnover = this.turnover;
    this.comp.ceo = this.ceo;
    this.comp.boardOfDirectors = this.boardOfDirectors;
    this.comp.listedStockExchange = this.listedInStockExchange;
    this.comp.sector = this.sector;
    this.comp.briefWriteUp = this.briefWriteup
    this.comp.companystockcode = this.companyStockCode;
    console.log(this.comp);
    this.service.addcompany(this.comp).subscribe(i=>{​​

      console.log(i.toString());}​​);
      this.router.navigateByUrl('/adminlogin');
  }

  updatecompany()
  {
    this.comp.companyId = this.companyId;
    this.comp.companyName = this.companyName;
    this.comp.turnover = this.turnover;
    this.comp.ceo = this.ceo;
    this.comp.boardOfDirectors = this.boardOfDirectors;
    this.comp.listedStockExchange = this.listedInStockExchange;
    this.comp.sector = this.sector;
    this.comp.briefWriteUp = this.briefWriteup
    this.comp.companystockcode = this.companyStockCode;
    console.log(this.comp);
    this.service.updatecompany(this.comp).subscribe(i=>{​​

      console.log(i.toString());}​​);

      this.router.navigateByUrl('/adminlogin');

  }

}
