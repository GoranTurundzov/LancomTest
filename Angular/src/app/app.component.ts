import { Measurement } from './measurement.model';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Forecast } from './forecast.model';
import { DateTimeService } from './DateTime.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  constructor(private httpClient: HttpClient, private dateTimeService : DateTimeService) {}
  title = 'weather-app-ng';
  data:Forecast = null;
  dateShown: number = 0;
  ngOnInit():void {
      this.getWeatherData();
  }

  getWeatherData() {
     this.httpClient.get<any>('https://api.openweathermap.org/data/2.5/forecast?q=Maribor&units=metric&appid=6fcdc04080b065827c805249b33e006c').subscribe(
      response => {
        var array:Measurement[] = [];
        for(var item of response.list){
       
          array.push(new Measurement(this.dateTimeService.convertDate(item.dt_txt), item.main.temp, item.main.feels_like, item.main.temp_min, item.main.temp_max, item.weather[0].description, item.weather[0].icon, item.wind.speed, item.main.humidity))
        }
        this.data = new Forecast(response.city.name, array)
      }
    );
  }
  changeDateShown(i){
    this.dateShown = i;
  }
}
