// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite pirma skaiciu: ");
int numOne = Int32.Parse(Console.ReadLine());
numOne++;

Console.WriteLine("Iveskite antra skaiciu: ");
var numTwo = Int32.Parse(Console.ReadLine());
numTwo--;
Console.WriteLine($"Results pirmas skaicius ++ = {numOne}, Results antras skaicius -- = {numTwo}");