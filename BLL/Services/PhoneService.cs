using BLL.Services.Contracts;
using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PhoneService : IPhoneService
    {
        public IUnitOfWork UnitOfWork { get; set; }

        public PhoneService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public async Task<List<Phone>> ShowAllPhones()
        {
           var result = await UnitOfWork.PhoneRepository.GetAllAsync();

            return result.ToList();
        }

        public async Task<bool> ChangePhone(Phone phone)
        {
            if(phone.Count==null || phone.Company==null || phone.Price==null || phone.Name == null)
            {
                return false;
            }

            await UnitOfWork.PhoneRepository.UpdateAsync(phone);
            await UnitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task DeletePhone(Phone phone)
        {
            await UnitOfWork.PhoneRepository.DeleteAsync(phone);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<bool> AddPhone (Phone phone)
        {
            if (phone.Count == null || phone.Company == null || phone.Price == null || phone.Name == null)
            {
                return false;
            }
            else
            {
                await UnitOfWork.PhoneRepository.AddAsync(phone);
                await UnitOfWork.SaveChangesAsync();
                return true;
            }
            
        }
    }
}
