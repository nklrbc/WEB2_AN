using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Persistence.Repository
{
    public class StaniceRepository : Repository<Stanica, int>, IStaniceRepository
    {
        public StaniceRepository(DbContext context) : base(context)
        {
        }
    }
}