import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RedVoznjeService {

  private redVoznjeUrl = 'http://localhost:52295/api/RedVoznje/Linije';  // URL to web api

  constructor(private http: HttpClient) 
  {
    console.log("usao u konstruktor");
  }

  getLinije (): Observable<string[]> {
    return this.http.get<string[]>(this.redVoznjeUrl)
      .pipe(
        catchError(this.handleError<string[]>('getLinije', []))
      );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
