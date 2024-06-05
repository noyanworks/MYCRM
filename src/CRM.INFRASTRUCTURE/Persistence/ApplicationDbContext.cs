using CRM.APPLICATION.Common.Interfaces;
using CRM.DOMAIN.Entities;
using CRM.DOMAIN.Entities.LST;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRM.INFRASTRUCTURE.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Notification> Notificiations { get; }
        public DbSet<Offer> Offers { get; }
        public DbSet<Request> Requests { get; }
        public DbSet<Sale> Sales { get; }
        public DbSet<TaskItem> Tasks { get; }
        public DbSet<UserPhone> UserPhones { get; }
        public DbSet<UserEmail> UserEmails { get; }

        // LST SCHEMA

        public DbSet<TaskStatusItem> TaskStatuses { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // BURAYA BOŞ CONSTRUCTURE AÇTIK. AÇMA SEBEBİMİZ options PARAMETRESİ İLE DependencyInjection İÇERİSİNDEKİ options parametresini bağlamak
        }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // yazmasak da olur, fakat ilerde :DbContext yerine ASP.NET Identity yapısını kullanacağımız durumlar da olacak, o zaman metodun faydası olacak.

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Persistence altındaki Configurations Classlarını uyandırmak için bunu yazdık. IConfiguration miras alan tüm classları kapsar. Classları tek tek tanımlamaya gerek yoktur. 
                
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}

//''APPLICATION'' KATMANINDA IApplicationDbContext SOYUT SINIFINI BURADA ApplicationDbContext SINIFI İLE IMPLEMENTE EDEREK SOMUT HALE GETİRMİŞ OLDUK.
