using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;
using WebApp.Persistence.UnitOfWork;

namespace WebApp.Controllers
{
    public class LinijaDetaljiController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public LinijaDetaljiController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }

        // GET: api/LinijaDetalji/Detalji/{nazivlinije}
        [HttpGet]
        public LinijeDetaljiBindingModel GetDetalji(string nazivLinije)
        {

            //string nazivLinije = "";

            LinijeDetaljiBindingModel ldbm = new LinijeDetaljiBindingModel();
            List<string> stanice = new List<string>();
            List<string> vremenaPolazaka = new List<string>();


            foreach (var linija in _unitOfWork.Linije.GetAll())
            {
                if (linija.NazivLinije == nazivLinije)
                {
                    foreach (var stanica in linija.Stanice)
                    {
                        stanice.Add(stanica.NazivStanice);
                    }
                    vremenaPolazaka = linija.VremenaPolaska;
                    break;
                }
            }

            ldbm.NazivLinije = nazivLinije;
            ldbm.Stanice = stanice;
            ldbm.VremenaDolaska = vremenaPolazaka;

            return ldbm;
        }
    }
}
