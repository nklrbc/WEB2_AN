using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Karta
    {
        private int id;
        private TipKarte tipKarte;
        private DateTime trajanjeKarte;

        public int Id { get => id; set => id = value; }
        public TipKarte TipKarte { get => tipKarte; set => tipKarte = value; }   
        public DateTime TrajanjeKarte { get => trajanjeKarte; set => trajanjeKarte = value; }

        public Karta(TipKarte _tipKarte, int _id)
        {
            this.TipKarte = _tipKarte;
            this.Id = _id;

            if (TipKarte == TipKarte.Vremenska)
            {
                trajanjeKarte = DateTime.Now;
                trajanjeKarte.AddSeconds(20);       //treba da budu sati (AddHours(1)), ali radimo simulaciju
            }

            else if (TipKarte == TipKarte.Dnevna)
            {
                trajanjeKarte = DateTime.Now;
                trajanjeKarte.AddSeconds(30);       //AddDays(1)
            }

            else if (TipKarte == TipKarte.Mesecna)
            {
                trajanjeKarte = DateTime.Now;
                trajanjeKarte.AddSeconds(40);       //AddMonths(1)
            }

            else
            {
                trajanjeKarte = DateTime.Now;       
                trajanjeKarte.AddSeconds(60);       //AddYears(1)
            }
        }
    }
}