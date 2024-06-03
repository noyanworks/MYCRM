using CRM.DOMAIN.Entities;
using CRM.DOMAIN.Entities.LST;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CRM.APPLICATION.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get;}
        DbSet<Employee> Employees { get; }
        DbSet<Notification> Notificiations { get; }
        DbSet<Offer> Offers { get; }
        DbSet<Request> Requests { get; }
        DbSet<Sale> Sales { get; }
        DbSet<TaskItem> Tasks { get; }
        DbSet<UserPhone> UserPhones { get; }
        DbSet<UserEmail> UserEmails { get; }

        public DbSet<UserStatus> UserStatuses { get; }
        public DbSet<TaskStatusItem> TaskStatuses { get; }


        Task SaveChangesAsync(); // CUSTOMER SERVICE İÇİNDE KULLANDIĞIMIZ SAVECHANGESASYNC METODUNU BURADA TANIMLADIK.
    }
}

// SOYUT OLDUĞU VE SET LERİNİ BURADA YAPMADIĞIMIZ İÇİN SET LERİ YAZMA GEREKSİNİMİ DUYMADIK.



// BU CLASSI NEDEN AÇTIK? CLEAN ARCHITECTURE YAPISI GEREĞİ, DOMAIN KATMANI BAĞIMLILIKLAR LİSTESİNDE MERKEZDE OLUR. YANİ DOMAIN KATMANI HİÇBİR BAĞIMLILIĞA GEREK DUYMAZ VE PROJENİN ÇEKİRDEĞİDİR. APPLICATION KATMANI DOMAIN KATMANINA BAĞIMLILIK DUYAR. INFRASTRUCTURE VE WEB API KATMANI DA APPLICATION KATMANINA BAĞIMLILIK DUYAR.

// APPLICATION KATMANININ DOMAIN KATMANINA BAĞIMLILIK DUYMASI İLE, DOMAIN KATMANINDAKİ PROPERTY LİSTESİNİ (DBSET'LERİ) KULLANABİLMESİ İÇİN SOYUT OLARAK BU SINIFI AÇTIK. INFRASTRUCTURE VE WEB API KATMANLARININ BU DBSET'LERE ERİŞEBİLMESİ ADINA DB SETLERİMİZİ BURAYA TANIMLIYORUZ.

// PAKET @@@@@@@@@@@@@@@@@@

// CLEAN ARCHITECTURE GEREĞİ PAKET BAĞIMLILIĞI İSTEMİYORUZ. FAKAT DBSET ÖZELLİĞİNİ KULLANABİLMEK İÇİN ''Entity Framework Core'' PAKETİNİ APPLICATION KATMANINA KURDUK