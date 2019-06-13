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
    public class ObrisiLinijeController : ApiController
    {
        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public ObrisiLinijeController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }

        [HttpPost]
        // POST: api/ObrisiLinije/ObrisiLiniju
        public IHttpActionResult PostObrisiLiniju([FromBody]string nazivLinije)
        {


            List<Linija> sveLinije = _unitOfWork.Linije.GetAll().ToList();


            foreach(var linija in sveLinije)
            {
                if (linija.NazivLinije == nazivLinije)
                {
                    _unitOfWork.Linije.Remove(linija);
                    _unitOfWork.Complete();
                }
            }

            


            return Ok();
        }
    }
}
