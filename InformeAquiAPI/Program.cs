using InformeAquiAPI.Domain.Application;
using InformeAquiAPI.Domain.Business;
using InformeAquiAPI.Domain.Core.Interfaces;
using InformeAquiAPI.Infrastructure.Adapter.Postgres;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IInformeAquiApplication, InformeAquiApplication>();
builder.Services.AddScoped<IInformeAquiBusiness, InformeAquiBusiness>();
builder.Services.AddScoped<IControleInformeAquiRepository, ControleInformeAquiRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
