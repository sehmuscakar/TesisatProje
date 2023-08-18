using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Tesisat.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.MyconfigureServices();//extensions klas�rdeki i�in
builder.Services.AddDbContext<ProjeContext>();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => { x.LoginPath = "/Admin/Login/Sign�n"; });  // e�er kimlik do�rulama yoksa bu sayfaya yonledirsin anlam�nda ,client giri� yapma kimlik do�rulamad�r sadece 
//builder.Services.AddSession();//oturum a�ma i�lemi ,kim giri� yapm��sa o ismi admindeki panele �ekmek istiyorsan session kullanmak zorundas�n 
builder.Services.AddMvc(config =>//bu t�m sistemi kilitliyor kimlik do�rulama oladan a��lmaz eri�ilemez
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => //otonatike olmayan k�sm� buraya yunlendirecek bunu yapmadan da  [AllowAnonymous] bu kodu controllera yazarak ta yapabilirsin 
{
    x.LoginPath = "/Admin/Login/Sign�n";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/Admin/Login/Error404", "?code={0}");//bu url e gidecek metot i�indeki paremtre code olmal� kesin ��nk� burda oyle yapt�k paretre ayn� olmas� laz�m 
app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseSession();//session kulln��m�

//app.UseStatusCodePages();// direk hata sayfas�n� 404 hatas�n� d�ndurur status code json format�nda d�nd�r�r yukardakini kullanacaksan bunu pasif yapman laz�m 

//app.UseAuthentication();// kimlik do�rulama (authentication) mekanizmas�n� etkinle�tiren bir y�ntem �a�r�s�d�r.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
