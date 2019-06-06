import { Component, OnInit } from '@angular/core';
import { CenovnikService } from '../cenovnik.service';
import { ArhivaCenovnika } from '../arhivaCenovnika';

@Component({
  selector: 'app-cenovnik',
  templateUrl: './cenovnik.component.html',
  styleUrls: ['./cenovnik.component.css']
})
export class CenovnikComponent implements OnInit {

  ArhivaCenovnikas : ArhivaCenovnika[];

  constructor(private cenovnikService: CenovnikService) { }

  ngOnInit() {
    this.getCenovnik();
  }

  getCenovnik(): void {
    this.cenovnikService.getCenovnik()
    .subscribe(ArhivaCenovnikas => this.ArhivaCenovnikas = ArhivaCenovnikas);
  }

}
