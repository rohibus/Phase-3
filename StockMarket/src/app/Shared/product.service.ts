import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {  Observable} from "rxjs";
import {User} from '../user';
import { Company } from '../company';
import { ExchangeComponent } from '../exchange/exchange.component';
import { Exchange } from '../exchange';
import { IPOentity } from '../ipoentity';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  username:string;
  usertype:string;
  path:string="http://localhost:51571/api/"
  constructor(private http:HttpClient) { }
  public GetAll():Observable<User[]>
  {
    return this.http.get<User[]>(this.path+"GetAll")
  }
  
    public userLogin(user:User)
    {​​

      return this.http.post(this.path +"User/check",user,{​​ responseType: 'text' }​​);

    }​​
    public adminLogin(user:User)
    {​​

      return this.http.post(this.path +"Admin/check",user,{​​ responseType: 'text' }​​);

    }​​

    public signup(user:User)

    {​​

      return this.http.post(this.path+"User/add",user,{​​ responseType: 'text' }​​);

    }​​

    public addcompany(comp:Company)

    {​​

      return this.http.post("http://localhost:55496/api/Company/addcompany",comp,{​​ responseType: 'text' }​​);

    }​​
    public updatecompany(comp:Company)

    {​​

      return this.http.put("http://localhost:55496/api/Company/updatecompany",comp,{​​ responseType: 'text' }​​);

    }​​

    public addExchange(exch:Exchange)
    {​​

      return this.http.post("http://localhost:50183/api/StockExchange/add",exch,{​​ responseType: 'text' }​​);

    }​​
    public getallexchange()
    {​​

      return this.http.get<Exchange[]>("http://localhost:50183/api/StockExchange/getall");

    }​​

    public addIPO(ipo:IPOentity)
    {​​

      return this.http.post("http://localhost:55496/api/Company/addIPO",ipo,{​​ responseType: 'text' }​​);

    }​​

    public displayipo()
    {​​

      return this.http.get<IPOentity[]>("http://localhost:55496/api/Company/getipo");

    }​​

    public getstockpricelist(code:number,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>

    {​​

      return this.http.get<number[]>("http://localhost:55496/api/Company/CompanypriceToFromList/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);

    }​​

    public getsectorstockpricelist(code:string,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>

    {​​

      return this.http.get<number[]>("http://localhost:54029/api/Sector/sectorpriceToFromList/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);

    }​​



}