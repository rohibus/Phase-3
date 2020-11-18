import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule} from "@angular/common/http";
import { ProductService } from './Shared/product.service';
import { FormsModule } from '@angular/forms';
import { AdminComponent } from './admin/admin.component';
import { UserhomeComponent } from './userhome/userhome.component';
import { SignupComponent } from './signup/signup.component';
import { CompanyComponent } from './company/company.component';
import { ExchangeComponent } from './exchange/exchange.component';
import { IPOdetailsComponent } from './ipodetails/ipodetails.component';
import { IPOdisplayComponent } from './ipodisplay/ipodisplay.component';
import { CompanychartComponent } from './companychart/companychart.component';
import { ChartsModule } from 'ng2-charts';
import { SectorchartComponent } from './sectorchart/sectorchart.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminComponent,
    UserhomeComponent,
    SignupComponent,
    CompanyComponent,
    ExchangeComponent,
    IPOdetailsComponent,
    IPOdisplayComponent,
    CompanychartComponent,
    SectorchartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ChartsModule
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
