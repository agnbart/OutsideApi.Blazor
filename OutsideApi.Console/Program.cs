using OutsideApi.Domain;
using OutsideApi.Infostructure.ConnectedServices;
using System.Net.Http.Json;

//string location = "Opole";
//string appId = "8697a4a54557736fd791b25a05b85624";

//IOpenWeatherMapService _weatherService = new OpenWeatherMapService();
//var result = await _weatherService.Retrive(location, appId);

//Console.WriteLine($"Location: {location}");
//Console.WriteLine($"Weather description: {result.weather.FirstOrDefault().description}");
//Console.WriteLine($"Temperature: {result.main.temp}");

string url = @"https://api.coinpaprika.com/v1/coins/btc-bitcoin";

IBitcoinMapService _bitcoinMapService = new BitcoinMapService();
var result = await _bitcoinMapService.Retrive();

Console.WriteLine($"Name: {result.name}");
Console.WriteLine($"Description: {result.symbol}");
Console.WriteLine($"Rank: {result.rank}");

//IFreeBookMapService _free = new FreeBookMapService();
//var result = await _free.Retrive();
//Console.WriteLine(result);