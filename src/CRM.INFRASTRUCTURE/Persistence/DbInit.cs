using CRM.INFRASTRUCTURE.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCRM.Infrastructure.Persistence
{
    public static class DbInitExtensions // ADINI INITIALIZE DAN ALDI
    {
        public static async Task DbInitialize(this IServiceScope scope)
        {
            
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated(); // TÜM VERİTABANINI SİL
            context.Database.EnsureDeleted(); // TÜM VERİTABANINI TEKRAR KUR

            // MIGRATION YAPISI SON DEĞİŞİKLİKLERİ KAYDETMEYE YARDIMCI OLURKEN, BU YÖNTEM VERİ TABANINI BAŞTAN YARATIR.


        }

    }
}



// VERİTABANI OLUŞTURMA VE AYNI ZAMANDA SEED İŞLEMİ YAPABİLMEK VE MERKEZİLEŞTİREBİLMEK ADINA AÇTIK. BU CLASSI WEBAPI/Program.cs/ içindeki 257. MADDE İÇİN YAPTIK ORAYI OKU

// BURAYA TAŞIDIKTAN SONRA FARKLI BİR SORUNLA KARŞILAŞTIK. PROGRAM CSDEN WEBAPPLICATION METODUNU GÖREMEDİĞİMİZ İÇİN INTERFACE KULLANMAK ZORUNDA KALDIK. YANİ PROGRAM CS İÇİNDE İNTERFACE'DEN (IServiceScope) DAN ÇAĞIRDIK. BURADA DA IServiceScope'u PARAMETRE OLARAK VERDİK Kİ PROGRAM CS UZERİNDEN ÇAĞIRABİLELİM. ANLAMADIYSAN 4. HAFTA CUMARTESİ SON DERS ARASINDAN SONRASINI İZLE.




