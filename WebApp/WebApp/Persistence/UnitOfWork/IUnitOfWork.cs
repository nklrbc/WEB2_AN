﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Persistence.Repository;

namespace WebApp.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICenovnikRepository Cenovnik { get; set; }
        IKupovinaKarteRepository KupovinaKarte { get; set; }
        IStaniceRepository Stanice { get; set; }
        ILinijeRepository Linije { get; set; }
        IApplicationUserRepository Korisnici { get; set; }
        int Complete();
    }
}
