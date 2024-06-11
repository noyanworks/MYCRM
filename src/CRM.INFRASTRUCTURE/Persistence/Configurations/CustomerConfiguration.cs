using CRM.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYCRM.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCRM.Infrastructure.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .ToTable(nameof(Customer), "dbo");
                // customer tablosu oluştur
            builder
                .Property(b => b.IdentityNumber).HasMaxLength(100)
                .HasMaxLength(100);


            builder
                .Property(b => b.CompanyName).HasMaxLength(250)
                .HasMaxLength(250);

            // aşağıdaki 1-1 ilişkidir. ister domainde propertyler ile ayarlayabiliriz, ister bu şekilde Configuration içinde ayarlayabiliriz. Bu da bir yöntemdir, domain de property ile ayarlandıysa gerek yoktur. veya burada ayarlandıysa domainde ayarlamaya gerek yoktur.

            builder
                .HasOne(e => e.UserFk) // customerin bir useri,
                .WithOne(e => e.CustomerFk) // userin bir customeri var
                .HasForeignKey<Customer>(e => e.UserId) // userid adında fkey i var
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            // hasforeignkey'i userConfiguration classında vermedik. çünkü customer user'a gidiyor.

            //OnDelete satırını şunun için yazdık, sql server üzerinde silme işlemlerinde fk var ise, stock olarak seçenek cascade gelir. Yani bir User'i sildiğimiz durumlarda user'a ait customer bilgileri de silinmesin diye, yani veri kaybetmemek adına DeleteBehavior Enum'undan NoAction seçeneğini çağırdık. DeleteBehavior.Cascade deseydik veriler silinecekti. Ama dememize gerek yok sql server stock halde cascade olarak ayarlıyor.


        }
    }
}

// ToTable yanındaki nameof(Customer) yerine sadece "Customer" da yazabilirdik. Sonuçları aynı sadece yazımı farklı

// id kolonunu ayarlamasak bile kendisi bir artacak şekilde ayarlıyor, id kolonu otomatik primary key olarak ayarlar not null otomatik ayarlar, id KOLONUNU KONFİGÜRE ETMEYE GEREK KALMAZ
