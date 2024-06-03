using CRM.APPLICATION.Common.Interfaces;
using CRM.APPLICATION.Services;
using CRM.APPLICATION.Services.Interfaces;
using CRM.INFRASTRUCTURE.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>();
//IApplicationDbContext gördüðümüz yerde artýk sql server'a baðýmlý olduðumuzu anlýyoruz.
builder.Services.AddTransient<ICustomerService, CustomerService>();
// ICustomerService, CustomerService'e gitsin gibi

var app = builder.Build();


using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
context.Database.EnsureCreated();// codeFirst DbCreating


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();