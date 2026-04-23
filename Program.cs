
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=finance.db"));

var app = builder.Build();

app.UseStaticFiles();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
