using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApp.Models;
using WebApp.Persistence;
using WebApp.Persistence.UnitOfWork;

namespace WebApp.Controllers
{
    public class KupovinakarteController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public KupovinakarteController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }

        //[HttpPost]
        //public IHttpActionResult PostKarta()
        //{
        //    return Ok();
        //}

        [HttpPost]
        // POST: api/Kupovinakarte/Karta
        public IHttpActionResult PostKarta([FromBody]string karta)
        {

            TipKarte tip = TipKarte.Dnevna;

            if (karta == "Vremenska")
            {
                tip = TipKarte.Vremenska;
            }
            else if(karta == "Dnevna")
            {
                tip = TipKarte.Dnevna;
            }

            Karta novaKarta = new Karta(tip);

            _unitOfWork.KupovinaKarte.Add(novaKarta);
            _unitOfWork.Complete();


            return Ok();
        }

       

    }
}