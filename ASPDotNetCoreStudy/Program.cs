
using ASPDotNetCoreStudy.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


string ConnectionString = "Server=DESKTOP-JUAIM1M\\SQLEXPRESS;Database=EFStudy;Integrated Security=true ;TrustServerCertificate=True";
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(ConnectionString));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
