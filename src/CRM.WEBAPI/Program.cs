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
//IApplicationDbContext g�rd���m�z yerde art�k sql server'a ba��ml� oldu�umuzu anl�yoruz.
//builder.Services.AddTransient<ICustomerService, CustomerService>();
// ICustomerService, CustomerService'e gitsin gibi

var app = builder.Build();


//using var scope = app.Services.CreateScope();
//var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//context.Database.EnsureCreated();

// (( MADDE 257 )) codeFirst DbOlu�turma ------ YUKARIDAK� SATIRI KALDIRACA�IZ, KOMPLE BA�KA B�R CLASS'A TA�IYIP ORADAN �A�IRACA�IZ (Environment.IsDevelopment i�inde o class'� �a��raca��z) O Y�ZDEN BURAYI KOMPLE YORUM SATIRI YAPIYORUM. YAN� BURADAK� KODU AYIRDIK.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.InitializeDb();

    // Persistance/DbInit i�indeki notlara ek; yani burada app. den gidecek �ekilde de�il de, scope dan gidecek �ekilde yapt�k.

    // @@@@@@ �NEML� @@@@@@ YAN� SCOPE KODU �ALI�TIKTAN SONRA BU KOD AYA�A KALKACAK, OLU�TURDU�UMUZ FK TABLOLARINI, CONFIGURATION CLASSLARINI �ALI�TIRACAK VE UYGULAMAYA SOKACAK.
    
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();