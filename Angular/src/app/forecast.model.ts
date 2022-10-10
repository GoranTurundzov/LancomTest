
import { Measurement } from "./measurement.model";

export class Forecast{
    constructor(
        public cityName: string, 
        public main:Measurement[], ){
        this.cityName = cityName;
        this.main = main;
    }
}