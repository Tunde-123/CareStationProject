using CareStationProject.Data;
using CareStationProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCon"));
}
);
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
   // options.Password.RequiredLength = 5;
    //options.Password.RequireLowercase = true;
    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);   
   // options.Lockout.MaxFailedAccessAttempts = 5;
   // options.SignIn.RequireConfirmedAccount = true;

    });
builder.Services.AddAuthentication()

.AddGoogle(options =>
{
    options.ClientId = "605080148150-44dthqu6t99a2ie1rs93l8a1k6g9009l.apps.googleusercontent.com";
    options.ClientSecret = "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";
});
builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = "/Account/Login";
});
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
