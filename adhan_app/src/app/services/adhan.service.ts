import { Injectable } from '@angular/core';
import { AdhanTimesDTO } from '../Adhan';
import { Observable, of } from 'rxjs';
import {HttpClient, HttpHeaders} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class AdhanService {
private apiUrl = "http://api.aladhan.com/v1/timings/"
currentDate: Date = new Date()
latitude!: any
longitude!: any

constructor(private http: HttpClient) { }

getAdhan(): Observable<AdhanTimesDTO>
{
  return new Observable<AdhanTimesDTO>(observer => {
    navigator.geolocation.getCurrentPosition(
      (position) => {
        this.successCallback(position);
        const totalApiUrl = `${this.apiUrl}${this.currentDate.getDate()}-${this.currentDate.getMonth() + 1}-${this.currentDate.getFullYear()}?latitude=${this.latitude}&longitude=${this.longitude}&method=2`;
        this.http.get<AdhanTimesDTO>(totalApiUrl).subscribe(
          (data) => observer.next(data),
          (error) => observer.error(error)
        );
      },
      (error) => observer.error(error)
    );
  });
  
}

successCallback(position: GeolocationPosition) {
  this.latitude = position.coords.latitude;
  this.longitude = position.coords.longitude;
  console.log(this.latitude + this.longitude)
}

errorCallback(error: GeolocationPositionError) {
  console.log("Error getting location: " + error.message);
}
}
