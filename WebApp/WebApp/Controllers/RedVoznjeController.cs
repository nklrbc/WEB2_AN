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
    public class RedVoznjeController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public RedVoznjeController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }


        // GET: api/RedVoznje/Linije
        public IEnumerable<string> GetLinije()
        {
            List<string> sveLinije = new List<string>();

            foreach (var linija in _unitOfWork.Linije.GetAll())
            {
                sveLinije.Add(linija.NazivLinije);         
            }


            return sveLinije;
        }


        
    }
}
