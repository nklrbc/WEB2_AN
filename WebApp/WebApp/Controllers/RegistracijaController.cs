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
    public class RegistracijaController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public RegistracijaController(IUnitOfWork unitofWork, DbContext context)
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
         // POST: api/Registracija/Registracija
         public IHttpActionResult PostRegistracija([FromBody]KorisnikRegistracijaBindingModel korisnik)
         {

            ApplicationUser au = new ApplicationUser
            {
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                Adresa = korisnik.Adresa,
                Mail = korisnik.Mail,
                Lozinka = korisnik.Lozinka,
                DatumRodjenja = korisnik.DatumRodjenja
            };

            _unitOfWork.Korisnici.Add(au);
             _unitOfWork.Complete();


             return Ok();
         }

    }
}
