import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Korisnik } from './korisnik';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class RegistracijaService {

  private registracijaUrl = 'http://localhost:52295/api/Registracija/Registracija';  // URL to web api



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

  public addKorisnik (korisnik : Korisnik){
    return this.http.post<Korisnik>(this.registracijaUrl, korisnik, httpOptions)
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      return of(result as T);
    };
  }
}
