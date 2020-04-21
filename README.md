# Covid19.NET

Covid19.NET is a .NET API Wrapper for the [Covid19 API](https://covid19api.com/)

## Installation
Installation is available in [NuGet](https://www.nuget.org/packages/Covid19.NET/)

## Usage

### Starting the client

```c#
using Covid19;

CovidAPIClient client = new CovidAPIClient();
```

### Get latest data
```c#
Latest latest = await client.GetLatestAsync();

Console.WriteLine("Total Confirmed Cases: " + latest.Global.TotalConfirmed);
Console.WriteLine("Total Recovered: " + latest.Global.TotalRecovered);
Console.WriteLine("Total Deaths: " + latest.Global.TotalDeaths);
Console.WriteLine("Newest Confirmed Cases since latest update: " + latest.Global.NewConfirmed);
Console.WriteLine("Newest Deaths since latest update: " + latest.Global.NewDeaths);
Console.WriteLine("Newest Recovered since latest update: " + latest.Global.NewRecovered);
Console.WriteLine("Last Updated: " + latest.UpdateDate);
```
- Latest also provides an array of countries one example of usage
```c#
Console.WriteLine("Latest Confirmed in the UK: " + latest.Countries.Where(x => x.Name == "United Kingdom").FirstOrDefault().TotalConfirmed);
```


### Get latest data by country slug
```c#
LatestCountry country = await client.GetLatestByCountryAsync("united-kingdom"); //Country slugs available at https://api.covid19api.com/countries

Console.WriteLine("New Recovered in the UK: " + country.NewRecovered);
```


### Get total country data by country slug 
```c#
List<Country> result = await client.GetTotalCountryDataAsync("united-kingdom");

// getting data from the first record 
Console.WriteLine("Country name: " + result.FirstOrDefault().Name);
Console.WriteLine("Confirmed Cases: " + result.FirstOrDefault().Confirmed);
Console.WriteLine("Deaths: " + result.FirstOrDefault().Confirmed);
Console.WriteLine("Recovered: " + result.FirstOrDefault().Recovered);
Console.WriteLine("Update Date: " + result.FirstOrDefault().UpdateDate);
