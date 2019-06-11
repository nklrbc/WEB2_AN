import { Component, OnInit, Input } from '@angular/core';
import { LinijaDetaljiService } from '../linija-detalji.service';
import { LinijaDetalji } from '../linijeDetalji';

@Component({
  selector: 'app-linija-detalji',
  templateUrl: './linija-detalji.component.html',
  styleUrls: ['./linija-detalji.component.css']
})
export class LinijaDetaljiComponent implements OnInit {

  @Input() nazivLinije : string;

  linijaDetalji : LinijaDetalji = new LinijaDetalji()


  constructor(private linijeDetalji: LinijaDetaljiService) { }

  ngOnInit() {
    console.log(this.nazivLinije)
    this.getLinijeDetalji();
  }

  getLinijeDetalji(): void {
    this.linijeDetalji.getDetaljiMock(this.nazivLinije)
    .subscribe(linijaDetalji => this.linijaDetalji = linijaDetalji);
  }

  
}
