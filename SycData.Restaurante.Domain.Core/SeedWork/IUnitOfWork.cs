using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Domain.Core.SeedWork
{
  public  interface IUnitOfWork
    {



        Task<int> SaveChangesAsync();

        bool CommintSaveChanges();
        bool SaveChanges();
    }
}
