import { Component, OnInit } from '@angular/core';
import { KupovinaService } from '../kupovina.service';


@Component({
  selector: 'app-kupovina-karte',
  templateUrl: './kupovina-karte.component.html',
  styleUrls: ['./kupovina-karte.component.css']
})
export class KupovinaKarteComponent implements OnInit {

  private daLiJePoslata = "Salje se";
  constructor(private kupovinaService: KupovinaService) { }

  ngOnInit() {
    this.addKartaNeregistrovani();
  }

  addKartaNeregistrovani(): void {
    this.kupovinaService.addKartaNeregistrovani().subscribe(() => this.daLiJePoslata = "Uspesno je kupljena karta");
  }
}