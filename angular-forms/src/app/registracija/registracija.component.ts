import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormArray } from '@angular/forms';
import { RegistracijaService } from '../registracija.service';
import { Korisnik } from '../korisnik';

@Component({
  selector: 'app-registracija',
  templateUrl: './registracija.component.html',
  styleUrls: ['./registracija.component.css']
})
export class RegistracijaComponent  {

  profileForm = this.fb.group({

    Ime: ['', Validators.required],
    Prezime: [''],
    Mail: [''],
    Lozinka: [''],
    Adresa: [''],
    DatumRodjenja: [''],


  });


  constructor(private fb : FormBuilder, private registracijaService: RegistracijaService) { }


  onSubmit()
  {
    let korisnik = new Korisnik()
    korisnik.Ime = this.profileForm.controls.Ime.value
    korisnik.Prezime = this.profileForm.controls.Prezime.value
    korisnik.Mail = this.profileForm.controls.Mail.value
    korisnik.Lozinka = this.profileForm.controls.Lozinka.value
    korisnik.Adresa = this.profileForm.controls.Adresa.value
    korisnik.DatumRodjenja = this.profileForm.controls.DatumRodjenja.value

    console.log(korisnik)
    this.registracijaService.addKorisnik(korisnik).subscribe(
      () => console.log("Uspesno registrovan"),
      err => {
        console.log("Puklo")
      }
      
    );
  }

}
