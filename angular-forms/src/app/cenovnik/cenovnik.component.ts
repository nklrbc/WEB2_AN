import { Component, OnInit } from '@angular/core';
import { BusService } from '../cenovnik.service';
import { ArhivaCenovnika } from '../arhivaCenovnika';

@Component({
  selector: 'app-cenovnik',
  templateUrl: './cenovnik.component.html',
  styleUrls: ['./cenovnik.component.css']
})
export class CenovnikComponent implements OnInit {

  cene : ArhivaCenovnika[];

  constructor(private busService: BusService) { }

  ngOnInit() {
    this.getCenovnik();
  }

  getCenovnik(): void {
    this.busService.getCenovnik()
    .subscribe(cene => this.cene = cene);
  }

}
