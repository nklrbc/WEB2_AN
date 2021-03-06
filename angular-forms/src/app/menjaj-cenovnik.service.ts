import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class MenjajCenovnikService {

  private kartaUrl = 'http://localhost:52295/api/MenjajCenovnik/MenjajCenovnik';  // URL to web api



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

  menjajCenovnik (tip : string, cena: string){
    return this.http.post(this.kartaUrl, '"' + tip + '_' +  cena + '"', httpOptions)
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
