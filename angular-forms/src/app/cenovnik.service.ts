import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { ArhivaCenovnika } from './arhivaCenovnika';
import { catchError } from 'rxjs/operators';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class CenovnikService {

  private ceneUrl = 'http://localhost:52295/api/Cenovnik/Cenovnik';  // URL to web api

  constructor(private http: HttpClient) 
  {
    console.log("usao u konstruktor");
  }

  getCenovnik (): Observable<ArhivaCenovnika[]> {
    return this.http.get<ArhivaCenovnika[]>(this.ceneUrl)
      .pipe(
        catchError(this.handleError<ArhivaCenovnika[]>('getCenovnik', []))
      );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
