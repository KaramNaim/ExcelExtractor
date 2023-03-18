using ExcelExtractor.ExcelDbContext;
using ExcelExtractor.Manager.Interface;
using ExcelExtractor.Manager.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString2 = builder.Configuration.GetConnectionString("Constr");
builder.Services.AddDbContext<ExcelContext>(x => x.UseSqlServer(connectionString2));

builder.Services.AddTransient<IExtractorService, ExtractService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
