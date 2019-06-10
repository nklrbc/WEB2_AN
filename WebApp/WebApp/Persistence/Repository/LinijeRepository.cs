using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Persistence.Repository
{
    public class LinijeRepository : Repository<Linija, int>, ILinijeRepository
    {
        public LinijeRepository(DbContext context) : base(context)
        {
        }
    }
}