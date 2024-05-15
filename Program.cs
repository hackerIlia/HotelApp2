using HotelApp2.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using NuGet.Protocol.Core.Types;
using HotelApp2.Models;
using HotelApp2.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<Hotel_DBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<DAL.EF.Hotel_DBContext_DAL>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
//builder.Services.AddDbContext<HModels.Hotel_DBContext_HModels>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString")));


builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddBlazorBootstrap();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "auth_token";
                options.LoginPath = "/login";
                options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
                options.AccessDeniedPath = "/accessDenied";
            });
builder.Services.AddAuthorization();
builder.Services.AddAntiforgery();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IRoomTypeService, HDRoomTypeService>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<HDRoomTypeC>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();
