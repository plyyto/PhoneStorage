using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Phone> Phones { get; set; }
    }
}
