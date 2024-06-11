using CRM.APPLICATION.Common.Interfaces;
using CRM.APPLICATION.Services;
using CRM.APPLICATION.Services.Interfaces;
using CRM.INFRASTRUCTURE.Persistence;
using MYCRM.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddWebApiServices();

//builder.Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>();
//IApplicationDbContext gördüðümüz yerde artýk sql server'a baðýmlý olduðumuzu anlýyoruz.
//builder.Services.AddTransient<ICustomerService, CustomerService>();
// ICustomerService, CustomerService'e gitsin gibi

var app = builder.Build();


//using var scope = app.Services.CreateScope();
//var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//context.Database.EnsureCreated();

// (( MADDE 257 )) codeFirst DbOluþturma ------ YUKARIDAKÝ SATIRI KALDIRACAÐIZ, KOMPLE BAÞKA BÝR CLASS'A TAÞIYIP ORADAN ÇAÐIRACAÐIZ (Environment.IsDevelopment içinde o class'ý çaðýracaðýz) O YÜZDEN BURAYI KOMPLE YORUM SATIRI YAPIYORUM. YANÝ BURADAKÝ KODU AYIRDIK.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.InitializeDb();

    // Persistance/DbInit içindeki notlara ek; yani burada app. den gidecek þekilde deðil de, scope dan gidecek þekilde yaptýk.

    // @@@@@@ ÖNEMLÝ @@@@@@ YANÝ SCOPE KODU ÇALIÞTIKTAN SONRA BU KOD AYAÐA KALKACAK, OLUÞTURDUÐUMUZ FK TABLOLARINI, CONFIGURATION CLASSLARINI ÇALIÞTIRACAK VE UYGULAMAYA SOKACAK.
    
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();