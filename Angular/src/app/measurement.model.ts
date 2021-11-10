export class Measurement {
    constructor(
        public dateTime: string,
        public temp:number,
        public feelsLike:number,
        public tempMin:number, 
        public tempMax:number, 
        public description:string,
        public icon:string,
        public windSpeed:number,
        public humidity:number,
        ){
            this.temp = temp;
            this.feelsLike = feelsLike;
            this.tempMin = tempMin;
            this.tempMax = tempMax;
            this.description = description;
            this.icon = icon;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
            this.dateTime = dateTime;
        }
        
        

}