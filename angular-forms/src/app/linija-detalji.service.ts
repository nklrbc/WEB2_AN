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
    return this.http.get<LinijaDetalji>(`${this.redVoznjeUrl}/${nazivLinije}`)  // this.redVoznjeUrl + '/' + nazivLinije
      .pipe(
        catchError(this.handleError<LinijaDetalji>('getDetalji', ))
      );
  }

  getDetaljiMock(nazivLinije: string): Observable<LinijaDetalji> {
    let linijaDetalji = new LinijaDetalji();
    linijaDetalji.NazivLinije = nazivLinije;
    linijaDetalji.Stanice = ['12', '2', '55'];
    linijaDetalji.VremenaDolaska = ['1', '6'];

    return of(linijaDetalji);
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
