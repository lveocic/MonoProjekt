using Microsoft.EntityFrameworkCore;
using MonoProjekt.Service.DAL;
using Ninject;
using Ninject.Web.Common;
using System.Reflection;
using System.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var kernel = new StandardKernel();
kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
//kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
kernel.Load(Assembly.GetExecutingAssembly());
var app = builder.Build();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<MonoProjektContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("MonoProjekt")));
var path = AppDomain.CurrentDomain.BaseDirectory;
var assemblies = Directory.GetFiles(path, "MonoProjekt.*.dll").Select(Assembly.LoadFrom).ToArray();

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
