using CRM.DOMAIN.Common;
using MYCRM.DOMAIN.Entities;
using MYCRM.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DOMAIN.Entities
{
    public class Customer : BaseEntity
    {
        public string? IdentityNumber { get; set; }
        public CustomerTypeEnum? CustomerType { get; set; }
        public string? CompanyName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public Guid? UserId { get; set; }
        public int? StatusTypeId { get; set; }
        public int? TitleId { get; set; }
        public int? TerritoryId { get; set; }
        public string? ProfileImageUrl { get; set; }

        #region Navigation Properties

        public User? UserFk { get; set; }


        #endregion Navigation Properties

        #region NAVIGATION PROPERTIES; YANİ USER VE CUSTOMER ARASINDA 1-1 İLİŞKİ SAĞLADIK. BUNU HER USER'IN BİR CUSTOMER'I OLDUĞUNU TANIMLAYABİLMEK İÇİN YAPTIK. USER -> CUSTOMER'A GİTSİN. @@@@@@@@@@@@@@@@@@@@@@ ÖNEMLİ @@@@@@@@@@@@@ BURADA YAPTIĞIMIZ 1-1 VEYA 1-N İLİŞKİLERİ AYNI ZAMANDA CONFIGURATION CLASSLARIMIZIN İÇİNDE DE TANIMLAYABİLİYORUZ.                                                                                                           

        
        
        #endregion

    }



}


// ''''SEALED'''' CLASS NEDİR? ÖRNEĞİN BU CLASSI; public sealed class Customer ŞEKLİNDE AÇSAYDIK, Customer CLASS'INI BİR BAŞKA CLASSA KALITIM VEREMEZDİK. ÖRNEĞİN public class abcde : Customer DİYEMEZDİK. SEALED KALITIM VERMEYİ ÖNLER FAKAT ÇOK KULLANILMAZ.

// ''ABSTRACT'' CLASSLAR ''SEALED'' OLAMAZ. ABSTRACT ZATEN BAŞKA CLASSA KALITIM VEREBİLİR DEMEKTİR. SEALED VEREMEZ DEMEKTİR. public sealed abstract class gibi bir tanım saçma olur.
