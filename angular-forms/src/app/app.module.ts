import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';
import { AppComponent } from './app.component';

import { LoginComponent } from './login/login.component';
import { RedVoznjeComponent } from './red-voznje/red-voznje.component';
import { CenovnikComponent } from './cenovnik/cenovnik.component';
import { KupovinaKarteComponent } from './kupovina-karte/kupovina-karte.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RedVoznjeComponent,
    CenovnikComponent,
    KupovinaKarteComponent,
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
