using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Verwaltung", "Mitarbeiter");
});

builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Mitarbeiter/Login";
        options.AccessDeniedPath = "/Mitarbeiter/Login";
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Mitarbeiter", policy =>
        policy.RequireRole("Mitarbeiter"));
});

var databaseFileName =
    builder.Configuration["Database:FileName"] ?? "flugmanagement.db";

var databasePath = Path.Combine(
    builder.Environment.ContentRootPath,
    "DATA",
    databaseFileName);

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite($"Data Source={databasePath}"));

builder.Services.AddScoped<FlightService>();
builder.Services.AddScoped<BookingService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Database.EnsureCreated();
    DbSeeder.Seed(db);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();