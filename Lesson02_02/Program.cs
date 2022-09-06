// See https://aka.ms/new-console-template for more information
int A=1;
int B=15;

Console.WriteLine($"A = {A}");
Console.WriteLine($"B = {B}");
(A, B) = (B, A);

Console.WriteLine($"A = : {A}, B = {B}");
