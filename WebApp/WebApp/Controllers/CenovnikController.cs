using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;
using WebApp.Persistence;
using WebApp.Persistence.UnitOfWork;

namespace WebApp.Controllers
{
    public class CenovnikController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        private DbContext _context;

        IUnitOfWork _unitOfWork;

        public CenovnikController(IUnitOfWork unitofWork, DbContext context)
        {
            _context = context;
            _unitOfWork = unitofWork;
        }


        // GET: api/Cenovnik/Cenovnik
        public IEnumerable<ArhivaCenovnikaBindingModel> GetCenovnik()
        {
            List<ArhivaCenovnikaBindingModel> acbm = new List<ArhivaCenovnikaBindingModel>();

            foreach(var cenovnik in _unitOfWork.Cenovnik.GetAll())
            {
                acbm.Add(new ArhivaCenovnikaBindingModel()
                {
                    Tip = cenovnik.Tip.ToString(),
                    Cena = cenovnik.Cena
                });
            }


            return acbm;
        }




    }
}
