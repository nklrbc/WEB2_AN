import { Component, OnInit } from '@angular/core';
import { LinijaDetaljiService } from '../linija-detalji.service';
import { LinijaDetalji } from '../linijeDetalji';

@Component({
  selector: 'app-linija-detalji',
  templateUrl: './linija-detalji.component.html',
  styleUrls: ['./linija-detalji.component.css']
})
export class LinijaDetaljiComponent implements OnInit {

  nazivLinije : string;
  linijaDetalji : LinijaDetalji;

  constructor(private linijeDetalji: LinijaDetaljiService) { }

  ngOnInit() {
    this.getLinijeDetalji();
  }

  getLinijeDetalji(): void {
    this.linijeDetalji.getDetalji(this.nazivLinije)
    .subscribe(linijaDetalji => this.linijaDetalji = linijaDetalji);
  }

  
}
