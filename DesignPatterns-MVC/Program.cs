using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatterns_MVC.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

IConfiguration configuration = builder.Configuration;
builder.Services.Configure<MyConfig>(configuration.GetSection("MyConfig"));

builder.Services.AddTransient((factory) =>
{
    return new LocalEarnFactory(configuration
        .GetSection("MyConfig").GetValue<decimal>("LocalPercentage"));
});
builder.Services.AddTransient((factory) =>
{
    return new ForeignEarnFactory(configuration
        .GetSection("MyConfig").GetValue<decimal>("ForeignPercentage"),
        configuration
        .GetSection("MyConfig").GetValue<decimal>("Extra"));
});

builder.Services.AddDbContext<DesignPatternsContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("Connection"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
