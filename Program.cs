using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using RPC.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RazorPagesUserContext>(options =>

    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesUserContext")));

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<RazorPagesUserContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesUserContext")));
}
else
{
    builder.Services.AddDbContext<RazorPagesUserContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesUserContext")));         
}

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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
