using Microsoft.EntityFrameworkCore;
using MonoProjekt.Service;
using MonoProjekt.Service.DAL;

using System.Reflection;
using System.Web;
using System;
using HttpModuleMagic;
using Ninject.Infrastructure.Disposal;
using Ninject.Web.Common;
using Ninject;
using Autofac;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<MonoProjektContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MonoProjektDb")));
var path = AppDomain.CurrentDomain.BaseDirectory;
var assemblies = Directory.GetFiles(path, "MonoProjekt.*.dll").Select(Assembly.LoadFrom).ToArray();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new MonoProjekt.Service.DIModule()));
builder.Services.AddAutoMapper(assemblies);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
