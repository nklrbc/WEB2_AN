using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LinijeDetaljiBindingModel
    {
        private string nazivLinije;
        private List<string> stanice = new List<string>();
        private List<string> vremenaDolaska = new List<string>();

        public string NazivLinije { get => nazivLinije; set => nazivLinije = value; }
        public List<string> Stanice { get => stanice; set => stanice = value; }
        public List<string> VremenaDolaska { get => vremenaDolaska; set => vremenaDolaska = value; }

        public LinijeDetaljiBindingModel()
        { }
    }
}