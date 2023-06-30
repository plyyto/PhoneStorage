using BLL.Services;
using BLL.Services.Contracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Views;

namespace WPF.ViewModel
{
    public class PhoneViewModel : BaseViewModel
    {
        private List<Phone> _phone;
        public List<Phone> Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        private string _company;
        public string Company
        {
            get { return _company; }
            set
            {
                _company = value;
                OnPropertyChanged(nameof(Company));
            }
        }


        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }


        private string _count;
        public string Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        private readonly IPhoneService _phoneService;

        public ICommand AddPhoneCommand { get; }
        public ICommand DeletePhoneCommand { get; }
        public ICommand EditPhoneCommand { get; }
        public PhoneViewModel(IPhoneService phoneService)
        {
            _phoneService = phoneService;
            Phone = new List<Phone>();

            LoadPhones();

            AddPhoneCommand = new RelayCommand(AddPhoneExecute, CanAddPhoneExecute);
            DeletePhoneCommand = new RelayCommand(DeletePhoneExecute, CanDeletePhoneExecute);
            EditPhoneCommand = new RelayCommand(EditPhoneExecute, CanChangePhoneExecute);
        }

        private async void AddPhoneExecute(object parameter)
        {
            var temp = new Phone();
            temp.Name = Name;
            temp.Company = Company;
            temp.Price = Price;
            temp.Count = Count;
            await _phoneService.AddPhone(temp);

            Name = "";
            Company = "";
            Price = "";
            Count = "";
            await LoadPhones();
        }

        

        private async void DeletePhoneExecute(object parameter)
        {
            if (parameter is Phone phone)
            {
                await _phoneService.DeletePhone(phone);
                Phone.Remove(phone);
                await LoadPhones();
            }
        }

        private async void EditPhoneExecute(object parameter)
        {
            if (parameter is Phone phone)
            {
                await _phoneService.ChangePhone(phone);
                Phone.Remove(phone);
                await LoadPhones();
            }
        }

        public async Task LoadPhones()
        {
            var result = await _phoneService.ShowAllPhones();

            Phone = result;

            OnPropertyChanged(nameof(Phone));
        }



        private bool CanDeletePhoneExecute(object parameter)
        {
            return true; 
        }
        private bool CanChangePhoneExecute(object parameter)
        {
            return true;
        }
        private bool CanAddPhoneExecute(object parameter)
        {
            return true;
        }
        

    }
}