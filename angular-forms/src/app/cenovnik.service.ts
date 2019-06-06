import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map ,} from 'rxjs/operators';
import { ArhivaCenovnika } from './arhivaCenovnika';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class BusService {

  private ceneUrl = 'api/cenovniks';  // URL to web api

  constructor(private http: HttpClient) { }

  /** GET heroes from the server */
  getCenovnik (): Observable<ArhivaCenovnika[]> {
    return this.http.get<ArhivaCenovnika[]>(this.ceneUrl)
      .pipe(
        catchError(this.handleError<ArhivaCenovnika[]>('getCenovnik', []))
      );
  }

  

  //////// Save methods //////////

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
