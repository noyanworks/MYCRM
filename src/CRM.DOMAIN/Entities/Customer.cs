using CRM.DOMAIN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DOMAIN.Entities
{
    public class Customer : BaseEntity
    {
        public int UserId { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public int? GenderId { get; set; }
        public int? StatusTypeId { get; set; }
        public short? CustomerType { get; set; }
        public int? TitleId { get; set; }
        public string? CompanyName { get; set; }
        public int? RegionId { get; set; }
        public DateOnly? BirthDate { get; set; }

    }


}


// ''''SEALED'''' CLASS NEDİR? ÖRNEĞİN BU CLASSI; public sealed class Customer ŞEKLİNDE AÇSAYDIK, Customer CLASS'INI BİR BAŞKA CLASSA KALITIM VEREMEZDİK. ÖRNEĞİN public class abcde : Customer DİYEMEZDİK. SEALED KALITIM VERMEYİ ÖNLER FAKAT ÇOK KULLANILMAZ.

// ''ABSTRACT'' CLASSLAR ''SEALED'' OLAMAZ. ABSTRACT ZATEN BAŞKA CLASSA KALITIM VEREBİLİR DEMEKTİR. SEALED VEREMEZ DEMEKTİR. public sealed abstract class gibi bir tanım saçma olur.
