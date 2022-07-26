using Autofac;
using Autofac.Extensions.DependencyInjection;
using DotVida.Infra.CrossCutting.IOC;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
    builder.RegisterModule(new ModuleIOC())
));

builder.Services.AddDbContext<DotVidaDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

//builder.Services.AddDbContext<DotVidaDbContext>(options =>
//  options.UseInMemoryDatabase("teste"));

var app = builder.Build();

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
