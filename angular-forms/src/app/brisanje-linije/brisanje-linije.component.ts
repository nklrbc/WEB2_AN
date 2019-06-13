import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { BrisanjeLinijeService } from '../brisanje-linije.service';

@Component({
  selector: 'app-brisanje-linije',
  templateUrl: './brisanje-linije.component.html',
  styleUrls: ['./brisanje-linije.component.css']
})
export class BrisanjeLinijeComponent {

  profileForm = this.fb.group({

    NazivLinije: ['', Validators.required],


  });



  private daLiJePoslata = "Brisanje u toku";
  constructor(private fb : FormBuilder, private brisanjeLinijeService: BrisanjeLinijeService) { }

  onSubmit()
  {
    let nazivLinije = this.profileForm.controls.NazivLinije.value;

    console.log(nazivLinije);
    this.brisanjeLinijeService.obrisiLinija(nazivLinije).subscribe(() => this.daLiJePoslata = "Uspesno je obrisana linija");
  }

}
