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
    public class DodavanjeLinijeController : ApiController
    {

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public DodavanjeLinijeController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }

        [HttpPost]
        // POST: api/DodavanjeLinije/Linija
        public IHttpActionResult PostLinija([FromBody]string nazivLinije)
        {


            Linija novaLinija = new Linija();
            novaLinija.NazivLinije = nazivLinije;
            novaLinija.Stanice = new List<Stanica>();
            novaLinija.VremenaPolaska = new List<string>();


            _unitOfWork.Linije.Add(novaLinija);
            _unitOfWork.Complete();


            return Ok();
        }

    }
}
