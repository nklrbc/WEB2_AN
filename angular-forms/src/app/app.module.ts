import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';
import { AppComponent } from './app.component';

import { LoginComponent } from './login/login.component';
import { RedVoznjeComponent } from './red-voznje/red-voznje.component';
import { CenovnikComponent } from './cenovnik/cenovnik.component';
import { KupovinaKarteComponent } from './kupovina-karte/kupovina-karte.component';
import { LinijaDetaljiComponent } from './linija-detalji/linija-detalji.component';
import { RegistracijaComponent } from './registracija/registracija.component';
import { DodavanjeLinijeComponent } from './dodavanje-linije/dodavanje-linije.component';
import { MenjajCenovnikComponent } from './menjaj-cenovnik/menjaj-cenovnik.component';
import { BrisanjeLinijeComponent } from './brisanje-linije/brisanje-linije.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RedVoznjeComponent,
    CenovnikComponent,
    KupovinaKarteComponent,
    LinijaDetaljiComponent,
    RegistracijaComponent,
    DodavanjeLinijeComponent,
    MenjajCenovnikComponent,
    BrisanjeLinijeComponent,

  ],
  imports: [
    BrowserModule,
    // other imports ...
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
