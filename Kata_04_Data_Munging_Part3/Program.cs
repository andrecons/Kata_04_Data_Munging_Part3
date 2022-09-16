using Kata_04_Data_Munging_Part3.StartupConfigs;

//Part 3 - FUSION

FootballHandler footballHandler = new FootballHandler();
footballHandler.PathPrinter();
footballHandler.Importer();
Console.WriteLine("\nSmallest Spread:" + footballHandler.GetSmallestSpread());

/*Printing days with smallest spread value*/
Console.WriteLine("Registered by Team/Teams");
string[] array = footballHandler.GetIndexSmallerSpread();

foreach (string team in array)
{
    Console.Write(team + " ");
}

Console.WriteLine("");

WeatherHandler weatherHandler = new WeatherHandler();
weatherHandler.PathPrinter();
weatherHandler.Importer();
Console.WriteLine("\nSmallest Spread:" + weatherHandler.GetSmallestSpread());
Console.WriteLine("Registered on day/days");

string[] daysWithLowestSpread = weatherHandler.GetIndexSmallerSpread();
foreach (string day in daysWithLowestSpread)
{
    Console.Write(day + " ");
}
