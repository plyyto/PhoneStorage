using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DAL;
using Microsoft.EntityFrameworkCore;
using DAL.Repositories.Contracts;
using DAL.Repositories;
using BLL.Services.Contracts;
using BLL.Services;
using WPF.ViewModel;

namespace WPF
{
    public partial class App : Application
    {
        private IHost _host;

        protected override void OnStartup(StartupEventArgs e)
        {
             _host = Host.CreateDefaultBuilder()
               .ConfigureServices((hostBuilderContext, serviceCollection) =>
               {
                   serviceCollection.AddDbContext<DBContext>(options =>
                   {
                       options.UseSqlServer("Data Source=DESKTOP-VIMRQAL\\SQLEXPRESS;Initial Catalog=PhoneTemp;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                   }, ServiceLifetime.Singleton);
                   serviceCollection.AddSingleton<IUnitOfWork, UnitOfWork>();
                   serviceCollection.AddSingleton<IPhoneRepository, PhoneRepository>();
                   serviceCollection.AddSingleton<IPhoneService, PhoneService>();
                   serviceCollection.AddSingleton<PhoneViewModel>();

                   serviceCollection.AddSingleton<MainWindow>();

               })
               .Build();

            _host.Start();

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.DataContext = _host.Services.GetRequiredService<PhoneViewModel>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            if (_host != null)
            {
                await _host.StopAsync();
                _host.Dispose();
            }

            base.OnExit(e);
        }
    }
}
