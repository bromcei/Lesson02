// See https://aka.ms/new-console-template for more information
string cityName = "Kaunas";
string streetName = "S.Daukanto";
int houseNo = 5;
DateTime builtDate = DateTime.Parse("1975-05-01");
DateTime startBuildingDate = DateTime.Parse("1973-08-01");

double yearDiff = (builtDate.Year - startBuildingDate.Year);
int monthDiff = ((builtDate.Year - startBuildingDate.Year) * 12) + builtDate.Month - startBuildingDate.Month;
int dayDiff = (builtDate.Date - startBuildingDate.Date).Days;

Console.WriteLine($"Miestas: {cityName},");
Console.WriteLine($"Gatve: {streetName},");
Console.WriteLine($"Namo numeris: {houseNo},");
Console.WriteLine($"Pastatymo data: {builtDate.ToString("yyyy-MM-dd")},");
Console.WriteLine($"Statybu trukme: {monthDiff} menesiai");
Console.WriteLine($"Statybu trukme: {dayDiff} dienos");

