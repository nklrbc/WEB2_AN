using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Stanica
    {
        private int id;
        private string nazivStanice;
        private List<Linija> linije = new List<Linija>();
        
        public int Id { get => id; set => id = value; }
        public string NazivStanice { get => nazivStanice; set => nazivStanice = value; }
        public List<Linija> Linije { get => linije; set => linije = value; }
        
        public Stanica(int _id, string _nazivStanice)
        {
            this.Id = _id;
            this.NazivStanice = _nazivStanice;
        }
    }
}