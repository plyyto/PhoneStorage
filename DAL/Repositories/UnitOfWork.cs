using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {


        public DBContext databaseContext { get; }

        public IPhoneRepository PhoneRepository { get; }

        public UnitOfWork(
           DBContext databaseContext,
           IPhoneRepository PhoneRepository
           )
        {
            this.databaseContext = databaseContext;
            this.PhoneRepository = PhoneRepository;

        }
        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }
    }
}
