using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class StanicaLinijas
    {
        private int stanica_id;
        private int linija_id;

        public int Stanica_id { get => stanica_id; set => stanica_id = value; }
        public int Linija_id { get => linija_id; set => linija_id = value; }
    }
}