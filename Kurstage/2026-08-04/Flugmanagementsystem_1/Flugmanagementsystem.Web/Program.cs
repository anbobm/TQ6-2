using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

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
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();