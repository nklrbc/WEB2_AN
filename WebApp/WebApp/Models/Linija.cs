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
        private string vremePolaska;

        public int Id { get => id; set => id = value; }
        public string NazivLinije { get => nazivLinije; set => nazivLinije = value; }
        public List<Stanica> Stanice { get => stanice; set => stanice = value; }
        public string VremePolaska { get => vremePolaska; set => vremePolaska = value; }

        public Linija(int _id, string _nazivLinije, string _vremePolaska)
        {
            this.Id = _id;
            this.NazivLinije = _nazivLinije;
            this.VremePolaska = _vremePolaska;
        }
    }
}