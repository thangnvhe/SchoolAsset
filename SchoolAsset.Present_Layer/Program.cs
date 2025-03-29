using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.Data;
using SchoolAsset.DataLayer.DbIntialier;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SchoolAssetDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolAsset")));

builder.Services.AddIdentity<IdentityUser,IdentityRole>(). AddEntityFrameworkStores<SchoolAssetDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(2); // Đăng xuất sau 2 phút không hoạt động
    options.SlidingExpiration = false; // Không reset lại thời gian nếu có hoạt động
});
builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
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
// Middleware kiểm tra session hết hạn và logout
app.Use(async (context, next) =>
{
    if (context.User.Identity.IsAuthenticated && !context.Request.Path.StartsWithSegments("/Identity/Account/Logout"))
    {
        var authResult = await context.AuthenticateAsync();
        if (authResult?.None ?? true)
        {
            context.Response.Redirect("/Identity/Account/Logout");
            return;
        }
    }
    await next();
});
app.UseAuthentication();
app.UseAuthorization();
SeedDatabase();
app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();
    }
}