import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { LinijaDetalji } from './linijeDetalji';

@Injectable({
  providedIn: 'root'
})
export class LinijaDetaljiService {

  private redVoznjeUrl = 'http://localhost:52295/api/LinijaDetalji/Detalji';  // URL to web api

  constructor(private http: HttpClient) 
  {
    console.log("usao u konstruktor");
  }

  getDetalji (nazivLinije : string): Observable<LinijaDetalji> {
    return this.http.get<LinijaDetalji>(this.redVoznjeUrl + "?nazivLinije=" + nazivLinije)  // this.redVoznjeUrl + '/' + nazivLinije
      .pipe(
        catchError(this.handleError<LinijaDetalji>('getDetalji', ))
      );
  }

  getDetaljiMock(nazivLinije: string): Observable<LinijaDetalji> {
    let linijaDetalji = new LinijaDetalji(['Zeleznica stanica', 'Centar', 'Kej'], 
    ['8:50', '9:30', '10:23', '12:22', '15:10', '18:00'], nazivLinije);


    return of(linijaDetalji);
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
