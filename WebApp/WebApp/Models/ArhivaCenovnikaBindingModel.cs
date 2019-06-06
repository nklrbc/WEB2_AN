using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ArhivaCenovnikaBindingModel
    {
        private string tip;
        private int cena;

        public string Tip { get => tip; set => tip = value; }
        public int Cena { get => cena; set => cena = value; }
    }
}