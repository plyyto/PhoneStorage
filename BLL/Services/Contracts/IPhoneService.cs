using DAL.Models;
using DAL.Repositories.Contracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Contracts
{
    public interface IPhoneService
    {
        public Task<List<Phone>> ShowAllPhones();

        public Task<bool> ChangePhone(Phone phone);

        public Task DeletePhone (Phone phone);

        public Task<bool> AddPhone(Phone phone);
        IUnitOfWork UnitOfWork { get; }
    }
}
