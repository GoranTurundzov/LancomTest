import { DateTimeService } from './DateTime.service';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ForecastComponent } from './forecast/forecast.component';
import { TemperatureComponent } from './temperature/temperature.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ForecastComponent,
    TemperatureComponent,

  ],
  imports: [
    BrowserModule,
    HttpClientModule
    
  ],
  providers: [DateTimeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
