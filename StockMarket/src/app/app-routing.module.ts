import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { CompanyComponent } from './company/company.component';
import { CompanychartComponent } from './companychart/companychart.component';
import { ExchangeComponent } from './exchange/exchange.component';
import { IPOdetailsComponent } from './ipodetails/ipodetails.component';
import { IPOdisplayComponent } from './ipodisplay/ipodisplay.component';
import {LoginComponent} from './login/login.component';
import { SectorchartComponent } from './sectorchart/sectorchart.component';
import { SignupComponent } from './signup/signup.component';
import { UserhomeComponent } from './userhome/userhome.component';


const routes: Routes = [
  {path:'Login',component:LoginComponent},
  {path:'adminlogin',component:AdminComponent},
  {path:'userlogin',component:UserhomeComponent},
  {path:'signup',component:SignupComponent},
  {path:'company',component:CompanyComponent},
  {path:'exchange',component:ExchangeComponent},
  {path:'ipodetails',component:IPOdetailsComponent},
  {path:'ipodisplay',component:IPOdisplayComponent},
  {path:'comchart',component:CompanychartComponent},
  {path:'sectorchart',component:SectorchartComponent},
  {path:'',redirectTo:'Login',pathMatch:"full"}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
