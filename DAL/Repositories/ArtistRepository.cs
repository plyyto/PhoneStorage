using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PhoneRepository : GenericRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(DBContext databaseContext)
            : base(databaseContext)
        {
        }

    }
}
