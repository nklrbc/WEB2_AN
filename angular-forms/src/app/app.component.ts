import { Component } from '@angular/core';

export type EditorType = 'redVoznje' | 'cenovnik' | 'login' | 'kupovinaKarte' | 'linijaDetalji';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  editor: EditorType = 'login';

  get showRedVoznje() {
    return this.editor === 'redVoznje';
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

  get showLinijaDetalji() {
    return this.editor === 'linijaDetalji';
  }

  toggleEditor(type: EditorType) {
    this.editor = type;
  }
}
