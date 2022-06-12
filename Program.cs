// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Ingrese su nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine("Hola, mi nombre es: " + nombre + " Y tengo: " + edad.ToWords(new System.Globalization.CultureInfo("es")) + " años");

