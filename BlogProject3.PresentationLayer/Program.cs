using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.BusinessLayer.Concrete;
using BlogProject3.BusinessLayer.Container;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.Context;
using BlogProject3.DataAccessLayer.EntityFramework;
using BlogProject3.EntityLayer.Concrete;
using BlogProject3.PresentationLayer.Models;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BlogContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BlogContext>().AddErrorDescriber<CustomIdentityErrorValidator>();



builder.Services.ContainerDependencies();

builder.Services.AddControllersWithViews().AddFluentValidation();

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
app.UseAuthentication();    //Bir sayfaya login olmak i�in kullan�l�r.
app.UseAuthorization();     //Herhangi bir sayfaya eri�ip eri�ilemeyece�ini belirler.Sadece member lar eri�sin/Admin ula�s�n...



// Alanlar i�in rota deste�i
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

// Varsay�lan rota
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);




//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");



//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});






app.Run();
