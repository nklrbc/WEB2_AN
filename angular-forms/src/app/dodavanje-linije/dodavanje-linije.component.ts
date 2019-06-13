import { Component, OnInit } from '@angular/core';
import { DodavanjeLinijeService } from '../dodavanje-linije.service';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-dodavanje-linije',
  templateUrl: './dodavanje-linije.component.html',
  styleUrls: ['./dodavanje-linije.component.css']
})
export class DodavanjeLinijeComponent  {

  profileForm = this.fb.group({

    NazivLinije: ['', Validators.required],


  });



  private daLiJePoslata = "Dodavanje u toku";
  constructor(private fb : FormBuilder, private dodavanjeLinijeService: DodavanjeLinijeService) { }

  onSubmit()
  {
    let nazivLinije = this.profileForm.controls.NazivLinije.value;

    console.log(nazivLinije);
    this.dodavanjeLinijeService.addLinija(nazivLinije).subscribe(() => this.daLiJePoslata = "Uspesno je dodata linija");
  }




}
