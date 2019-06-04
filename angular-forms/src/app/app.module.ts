import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';

import { LoginComponent } from './login/login.component';
import { RedVoznjeComponent } from './red-voznje/red-voznje.component';
import { CenovnikComponent } from './cenovnik/cenovnik.component';

@NgModule({
  declarations: [
    AppComponent,

    LoginComponent,
    RedVoznjeComponent,
    CenovnikComponent,
  ],
  imports: [
    BrowserModule,
    // other imports ...
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
