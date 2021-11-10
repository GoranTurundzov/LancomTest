import { Injectable } from '@angular/core';

export class DateTimeService{

    convertDate(dateTime: string){
        let dateArray = dateTime.split(" ");
        let formatedDate = `${this.replaceMonth(dateArray[0])} at ${this.replaceTime(dateArray[1])} `    
        console.log(formatedDate)
        return formatedDate;
    }

    replaceMonth(date: string){
        let splitDate = date.split("-");
        switch (splitDate[1]){
            case "1":
                splitDate[1] = "January";
            break;
            case "2":
                splitDate[1] ="February";
            break;
            case "3":
                splitDate[1] = "March";
            break;
            case "4":
                splitDate[1] = "April";
            break;
            case "5":
                splitDate[1] = "May";
            break;
            case "6":
                splitDate[1] = "June";
            break;
            case "7" :
                splitDate[1] = "July";
            break;
            case "8":
                splitDate[1] = "August";
            break;
            case "9":
                splitDate[1] = "September";
            break;
            case "10":
                splitDate[1] = "Octomber";
            break;
            case "11":
                splitDate[1] = "November";
            break;
            case "12": 
            splitDate[1] = "December";
            break;
            default: 
                splitDate[1] = "Month";
            break;
        }

        return `${splitDate[1]} ${splitDate[2]}, ${splitDate[0]}`
    }

    replaceTime(time: string){
        let timeArray = time.split(":");
        if(parseInt(timeArray[0]) > 12){
            timeArray[0] = `${parseInt(timeArray[0])-12}`
            return `${timeArray[0]}:${timeArray[1]} PM`
        }
        else if (parseInt(timeArray[0]) === 0){
             return `12:${timeArray[1]} PM`
        }
        return `${timeArray[0]}:${timeArray[1]} AM`
        
    }
}