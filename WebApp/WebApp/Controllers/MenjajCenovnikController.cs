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
    public class MenjajCenovnikController : ApiController
    {
        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public MenjajCenovnikController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }

        [HttpPost]
        // POST: api/MenjajCenovnik/MenjajCenovnik
        public IHttpActionResult PostMenjajCenovnik([FromBody]string tip_cena)
        {

            string[] tip_cena_parsed = tip_cena.Split('_');
            string tip = tip_cena_parsed[0];
            int cena = Int32.Parse(tip_cena_parsed[1]);

            ArhivaCenovnika ac = new ArhivaCenovnika();
            int index = -1;

            if (tip == "Vremenska" || tip == "vremenska")
            {
                index = 1;
            }
            else if (tip == "Godisnja" || tip == "godisnja")
            {
                index = 4;
            }
            else if (tip == "Dnevna" || tip == "dnevna")
            {
                index = 2;
            }
            else if (tip == "Mesecna" || tip == "mesecna")
            {
                index = 3;
            }

            ac = _unitOfWork.Cenovnik.Get(index);
            ac.Cena = cena;

            _unitOfWork.Cenovnik.Update(ac);
            //_unitOfWork.Linije.Add(novaLinija);
            _unitOfWork.Complete();


            return Ok();
        }
    }
}
