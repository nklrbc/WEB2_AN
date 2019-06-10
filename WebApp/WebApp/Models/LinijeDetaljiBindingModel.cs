using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LinijeDetaljiBindingModel
    {
        private string nazivLinije;
        private List<string> sveStanice = new List<string>();
        private List<string> svaVremenaPolaska = new List<string>();

        public string NazivLinije { get => nazivLinije; set => nazivLinije = value; }
        public List<string> SveStanice { get => sveStanice; set => sveStanice = value; }
        public List<string> SvaVremenaPolaska { get => svaVremenaPolaska; set => svaVremenaPolaska = value; }

        public LinijeDetaljiBindingModel()
        { }
    }
}