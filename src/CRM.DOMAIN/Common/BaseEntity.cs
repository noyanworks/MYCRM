using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DOMAIN.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}


// BU CLASSI ENTITIES ALTINDAKİ CLASSLARDA ORTAK OLARAK BULUNAN ID PROPERTYSİ İÇİN AÇTIK. KOD KALABALIĞINDAN KURTULMAK ADINA İÇİNDE ID BARINDIRAN TÜM CLASSLARA MİRAS OLARAK VERECEĞİZ.

// abstract class OLARAK AÇMAMIZIN SEBEBİ CLASSIN SOYUT GİBİ DAVRANMASIDIR. YANİ,
// var i = new BaseEntity() ŞEKLİNDE INSTANCE ALINMASINI ÖNLEMEKTİR.
// abstract sınıflar interfaceler gibi kullanılabilir, override edilebilir.
