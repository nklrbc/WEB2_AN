import { Component, OnInit } from '@angular/core';
import { RedVoznjeService } from '../red-voznje.service';
import { LinijaDetaljiService } from '../linija-detalji.service';
import { LinijaDetalji } from '../linijeDetalji';

export type EditorType = 'linijaDetalji'

@Component({
  selector: 'app-red-voznje',
  templateUrl: './red-voznje.component.html',
  styleUrls: ['./red-voznje.component.css']
})
export class RedVoznjeComponent  {

  Linije : string[];

  prikaziDetalje : boolean = false;
  parentLinijaDetalji : LinijaDetalji;

  parentNazivLinije : string;

  lin = []

  constructor(private redVoznjeService: RedVoznjeService, private linijeDetaljiService: LinijaDetaljiService) { }

  ngOnInit() {
    this.getLinije();
  }

  getLinije(): void {
    this.redVoznjeService.getLinije()
    .subscribe(Linije => this.Linije = Linije);
  }

  editor: EditorType = 'linijaDetalji';

  get showLinijaDetalji() {
    return this.editor === 'linijaDetalji';
  }

  toggleEditor(type: EditorType) {
    this.editor = type;
  }

  prikazDetaljaLinije(linija: string) {
    this.prikaziDetalje = true;
    this.parentNazivLinije = linija;
    this.lin[0] = linija
    // this.linijeDetaljiService.getDetaljiMock(linija).subscribe(res => {
    //   console.log(res);
    //   this.parentLinijaDetalji = res;
    // });
  }
}
