import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { MenjajCenovnikService } from '../menjaj-cenovnik.service';

@Component({
  selector: 'app-menjaj-cenovnik',
  templateUrl: './menjaj-cenovnik.component.html',
  styleUrls: ['./menjaj-cenovnik.component.css']
})
export class MenjajCenovnikComponent  {

  profileForm = this.fb.group({

    NazivTipa: ['', Validators.required],
    Cena : [''],

  });



  private daLiJePoslata = "Menjanje u toku";
  constructor(private fb : FormBuilder, private menjajCenovnikService: MenjajCenovnikService) { }

  onSubmit()
  {
    let tip = this.profileForm.controls.NazivTipa.value;
    let cena = this.profileForm.controls.Cena.value;
    console.log(tip);
    this.menjajCenovnikService.menjajCenovnik(tip, cena).subscribe(() => this.daLiJePoslata = "Uspesno je promenjena cena");
  }



}
