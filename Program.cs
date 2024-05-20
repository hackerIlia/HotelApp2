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

builder.Services.AddDbContextFactory<Hotel_DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddDbContextFactory<HModels.Hotel_DBContext_HModels>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddTransient<Hotel_DBContext>();
builder.Services.AddTransient<HModels.Hotel_DBContext_HModels>();


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

builder.Services.AddScoped<IGeneralService<HModels.RoomType>, HDRoomTypeService>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<HDRoomTypeC>();

builder.Services.AddScoped<IGeneralService<HModels.Room>, BLL.Services.Room>();
builder.Services.AddScoped<HotelApp2.Controllers.Room>();

builder.Services.AddScoped<IGeneralService<HModels.Booking>, BLL.Services.Booking>();
builder.Services.AddScoped<HotelApp2.Controllers.Booking>();

builder.Services.AddScoped<IGeneralService<HModels.Living>, BLL.Services.Living>();
builder.Services.AddScoped<HotelApp2.Controllers.Living>();

builder.Services.AddScoped<IGeneralService<HModels.BookingStatus>, BLL.Services.BookingStatuses>();
builder.Services.AddScoped<HotelApp2.Controllers.BookingStatuses>();

builder.Services.AddScoped<IGeneralService<HModels.GuestBooking>, BLL.Services.GuestBooking>();
builder.Services.AddScoped<HotelApp2.Controllers.GuestBooking>();

builder.Services.AddScoped<IGeneralService<HModels.GuestLiving>, BLL.Services.GuestLiving>();
builder.Services.AddScoped<HotelApp2.Controllers.GuestLiving>();

builder.Services.AddScoped<IGeneralService<HModels.Living>, BLL.Services.Living>();
builder.Services.AddScoped<HotelApp2.Controllers.Living>();

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
