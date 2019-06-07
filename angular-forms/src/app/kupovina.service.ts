import { Injectable } from '@angular/core';
import { of, Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class KupovinaService {

  private kartaUrl = 'http://localhost:52295/api/Kupovinakarte/Karta';  // URL to web api



  constructor(private http: HttpClient) 
  {
    console.log("usao u konstruktor");
  }

  /*getKupovina (): Observable<KartaNeregistrovani[]> {
    return this.http.get<KartaNeregistrovani[]>(this.ceneUrl)
      .pipe(
        catchError(this.handleError<KartaNeregistrovani[]>('getKupovina', []))
      );
  }*/

  addKartaNeregistrovani (){
    let xy = "Vremenska";
    return this.http.post(this.kartaUrl, '"' + xy + '"', httpOptions)
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}