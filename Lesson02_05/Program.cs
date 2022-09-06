// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite staciakampio ilgi: ");
double ilgis = double.Parse(Console.ReadLine().ToString().Replace(".", ","));


Console.WriteLine("Iveskite staciakampio ploti: ");
double plotis = double.Parse(Console.ReadLine().ToString().Replace(".", ","));

Console.WriteLine($"Staciakampio plotis lygus {plotis * ilgis}");
