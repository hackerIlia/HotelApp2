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

builder.Services.AddScoped<IGeneralService<HModels.HDRoomType>, HDRoomTypeService>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<HDRoomTypeC>();

builder.Services.AddScoped<IGeneralService<HModels.HRoom>, RoomService>();
builder.Services.AddScoped<HotelApp2.Controllers.Room>();

builder.Services.AddScoped<IGeneralService<HModels.HBooking>, BLL.Services.Booking>();
builder.Services.AddScoped<HotelApp2.Controllers.Booking>();

builder.Services.AddScoped<IGeneralService<HModels.HLiving>, BLL.Services.Living>();
builder.Services.AddScoped<HotelApp2.Controllers.Living>();

builder.Services.AddScoped<IGeneralService<HModels.HDBookingStatus>, BLL.Services.BookingStatuses>();
builder.Services.AddScoped<HotelApp2.Controllers.BookingStatuses>();

builder.Services.AddScoped<IGeneralService<HModels.HGuestBooking>, BLL.Services.GuestBooking>();
builder.Services.AddScoped<HotelApp2.Controllers.GuestBooking>();

builder.Services.AddScoped<IGeneralService<HModels.HGuestLiving>, BLL.Services.GuestLiving>();
builder.Services.AddScoped<HotelApp2.Controllers.GuestLiving>();

builder.Services.AddScoped<IGeneralService<HModels.HLiving>, BLL.Services.Living>();
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
