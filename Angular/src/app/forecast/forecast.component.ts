import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Measurement } from '../measurement.model';


@Component({
  selector: 'app-forecast',
  templateUrl: './forecast.component.html',
  styleUrls: ['./forecast.component.css']
})
export class ForecastComponent implements OnInit {
  @Input() forecast:Measurement[] =[];

  @Output() changeDate: EventEmitter<number> = new EventEmitter<number>(
    
 
  );
  constructor() { }
  
  ngOnInit(): void {
  }

  onClick(index): void {
    this.changeDate.emit(index)
    console.log(index);
  }

}
