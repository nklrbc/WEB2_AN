import { Component } from '@angular/core';

export type EditorType = 'redVoznje' | 'cenovnik' | 'login' | 'kupovinaKarte' | 'linijaDetalji' | 'registracija';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  editor: EditorType; //= 'login';

  get showRedVoznje() {
    return this.editor === 'redVoznje';
  }

  get showRegistracija() {
    return this.editor === 'registracija';
  }

  get showCenovnik() {
    return this.editor === 'cenovnik';
  }

  get showLogin() {
    return this.editor === 'login';
  }

  get showKupovina() {
    return this.editor === 'kupovinaKarte';
  }


  toggleEditor(type: EditorType) {
    this.editor = type;
  }
}
