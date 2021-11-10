import { Measurement } from './../measurement.model';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-temperature',
  templateUrl: './temperature.component.html',
  styleUrls: ['./temperature.component.css']
})
export class TemperatureComponent implements OnInit {
  @Input() data: Measurement;

  constructor() { }

  ngOnInit(): void {
  }

}
