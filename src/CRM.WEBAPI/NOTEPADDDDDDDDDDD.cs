// PROPERTY GROUP @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

// PROJE TANIMLARI İÇİNDE <PropertyGroup> </PropertyGroup> SATIRLARI ARASINDA TANIMLADIĞIMIZ < AssemblyName > <RootNamespace> ÖZELLİKLERİ NEDİR?


// < AssemblyName bunu dll dosyasında istediğimiz ismi verebilmek için yaptık, çok da önemli değil. dışarıya hangi isimle çıkmasını istiyorsak.

// RootNameSpace ÖZELLİĞİNİ, HER CLASSDA BULUNAN namespace ALANINI İSTEDİĞİMİZ GİBİ DEĞİŞTİREBİLMEK AMACI İLE KULLANDIK. BU ÖZELLİK DE ÇOK ÖNEMLİ DEĞİL.







// DIRECTORY.BUILD @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

// DIRECTORY.BUILD İÇİNDEKİ <TreatWarningAsErrors>false</TreatWarningAsErrors> ÖZELLİĞİ, projede warningleri de hata gibi gör / kaldır SEÇENEĞİDİR.



// DIRECTORY.PACKAGES

// PROJEDEKİ <ItemGrup> KANALI İÇİNDEKİ <PackageReferance/> KISMINI KOMPLE KOPYALAYIP DIRECTORY.PACKAGES İÇİNE YAPIŞTIRIYORUZ. BURASI ÖNEMLİ; PackageReferance İSMİ ARTIK PackageVersion OLARAK DEĞİŞTİRİLİYOR. ARTIK TÜM PROJELERDEN DE ÖRNEĞİN  Version="8.0.6" KISMINI SİLEBİLİRİZ. DİRECTORY HARİÇ.

//DIRECTORY.PACKAGES İÇİNDEKİ KISMI DA MICROSOFT SITESINDEN ManagePackageVersionsCentrally YAZARAK BULABILIRIZ @@@



// DATA ANNOTATIONS @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

// DOMAINDEKI ENTITYLERIMIZ 2 FARKLI YÖNTEMLE KONFİGÜRE ( [MaxLength] vs..) EDİLEBİLİR. 1) DATA ANNOTATIONS 2) DbContext içinde OnModelCreating yani FluentApi YÖNTEMİ 3) HER ENTITYE AIT KONFİGURASYONLARI, Configurations KLASÖRÜ ALTINDA ÖRNEĞİN CustomerConfigurations CLASSI İÇİNDE KONFİGÜRE EDİP DBCONTEXT'DE TANIMLAYABİLİRİZ. @@@@@@@@@@@ ÖNEMLİ; DBCONTEXT İÇİNDE OnModelCreating ALTINDA TEK TEK HER ENTITIYI TANIMLAYABİLECEĞİMİZ GİBİ, ****** ApplyConfigurationsFromAssembly ***** YÖNTEMİ İLE TOPLUCA DA TANIMLAYABİLİRİZ. ÖRNEKLERİ İÇİN ApplicationDbContext ve Infrastructure / Configurations KISIMLARINI İNCELE.



// MIGRATION @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ MIGRATION YAPISI SON DEĞİŞİKLİKLERİ KAYDETMEYE YARDIMCI OLURKEN, /INFRASTRUCTURE/Persistance/DbInitialize YAPISI HER AYAĞA KALKTIĞINDA DATABASE'I BAŞTAN YARATIR. @@@@@@@@@@@@@@@@ MIGRATION İLE ARALARINDAKİ TEMEL FARK BUDUR @@@@@@@@@@@@

// MIGRATION İLE TABLOLAR OLUŞTURMAK, Add-Migration XXX dediğimiz zaman tabloları oluşturur. Add-Migration XXX -o Persistence/Migrations DERSEK PERSISTENCE ALTINDA OLUŞTUR SONRA update-database
// MIGRATION İÇİN TOOLS VE DESIGN PAKETLERİ YÜKLÜ OLMALIDIR. TOOLS MIGRATION KODU YAZABİLMEMİZ İÇİN-DESIGN RUNTIME BİR KOD OLMADIĞI İÇİN.
// MIGRATE KOMUTUNU KONSOLDA KULLANABİLECEĞİMİZ GİBİ, DbInit içinde context.Database.Migrate() diyerek de RUNTIME KULLANABILIRIZ.
// update-database 0 YAPARSAK VERİTABANINDAKİ TABLOLARI SIFIRLAR FAKAT PROJEDE EN BAŞINDAN BERİ MIGRATION KULLANILDIYSA.




















