using CRM.APPLICATION.Common.Interfaces;
using CRM.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.INFRASTRUCTURE.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = "Server=(localdb)\\MYCRM; Database=MYCRM_DEV;";
            optionsBuilder.UseSqlServer(cs);
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

//''APPLICATION'' KATMANINDA IApplicationDbContext SOYUT SINIFINI BURADA ApplicationDbContext SINIFI İLE IMPLEMENTE EDEREK SOMUT HALE GETİRMİŞ OLDUK.
