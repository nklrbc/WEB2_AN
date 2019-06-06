using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Popust
    {
        private TipRegistrovanogKorisnika korisnik;
        private double koeficijent;

        [Key]
        public TipRegistrovanogKorisnika Korisnik { get => korisnik; set => korisnik = value; }
        public double Koeficijent { get => koeficijent; set => koeficijent = value; }
    }
}