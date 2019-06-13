import { Component } from '@angular/core';

export type EditorType = 'redVoznje' | 'cenovnik' | 'login' | 'kupovinaKarte' 
                          | 'linijaDetalji' | 'registracija' | 'dodavanjeLinije' 
                          | 'menjajCenovnik' | 'brisanjeLinije';

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

  get showDodavanjeLinije() {
    return this.editor === 'dodavanjeLinije';
  }

  get showMenjajCenovnik() {
    return this.editor === 'menjajCenovnik';
  }

  get showBrisanjeLinije() {
    return this.editor === 'brisanjeLinije';
  }


  toggleEditor(type: EditorType) {
    this.editor = type;
  }
}
