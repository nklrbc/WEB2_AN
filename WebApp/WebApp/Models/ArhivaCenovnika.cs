using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ArhivaCenovnika
    {
        private int id;
        private DateTime from;
        private DateTime to;
        private TipKarte tip;
        private int cena;

        
        public DateTime From { get => from; set => from = value; }
        public DateTime To { get => to; set => to = value; }
        public TipKarte Tip { get => tip; set => tip = value; }
        public int Cena { get => cena; set => cena = value; }
        public int Id { get => id; set => id = value; }
    }
}