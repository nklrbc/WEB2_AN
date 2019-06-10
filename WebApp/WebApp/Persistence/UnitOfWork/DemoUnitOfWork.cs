﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unity;
using WebApp.Persistence.Repository;

namespace WebApp.Persistence.UnitOfWork
{
    public class DemoUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        [Dependency]
        public ICenovnikRepository Cenovnik { get; set; }
        [Dependency]
        public IKupovinaKarteRepository KupovinaKarte { get; set; }
        [Dependency]
        public IStaniceRepository Stanice { get; set; }
        [Dependency]
        public ILinijeRepository Linije { get; set; }


        public DemoUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}