import { Component } from '@angular/core';

export type EditorType = 'redVoznje' | 'cenovnik' | 'login';

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

  toggleEditor(type: EditorType) {
    this.editor = type;
  }
}
