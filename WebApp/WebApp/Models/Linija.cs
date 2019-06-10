using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Linija
    {
        private int id;
        private string nazivLinije;
        private List<Stanica> stanice = new List<Stanica>();
        private List<string> vremenaPolaska = new List<string>();

        public int Id { get => id; set => id = value; }
        public string NazivLinije { get => nazivLinije; set => nazivLinije = value; }
        public List<Stanica> Stanice { get => stanice; set => stanice = value; }
        public List<string> VremenaPolaska { get => vremenaPolaska; set => vremenaPolaska = value; }

        public Linija(int _id, string _nazivLinije, List<string> _vremenaPolaska)
        {
            this.Id = _id;
            this.NazivLinije = _nazivLinije;
            this.VremenaPolaska = _vremenaPolaska;
        }

        public Linija()
        {

        }
    }
}