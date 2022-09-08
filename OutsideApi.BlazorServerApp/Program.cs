using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using OutsideApi.BlazorServerApp.Data;
using OutsideApi.Infostructure.ConnectedServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IOpenWeatherMapService, OpenWeatherMapService>();
builder.Services.AddSingleton<IBitcoinMapService, BitcoinMapService>();
builder.Services.AddSingleton<IFreeBookMapService, FreeBookMapService>();
builder.Services.AddSingleton<IBooksOfAuthorService, BooksOfAuthorService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
