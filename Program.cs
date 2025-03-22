using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moviemanager.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MoviemanagerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviemanagerContext") ?? throw new InvalidOperationException("Connection string 'MoviemanagerContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
