using System.Collections.Generic;// jag använde system.generic.collections så att jag kan använda mig av listor.

List<string> cities= new List<string>(); // detta är en den tomma listan som heter cities som kan hålla strings
while (true)
{
    Console.WriteLine("Ange en city och skriv exit för att avsluta");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit") // om användaren skriver exit så stängs programmet 
    {
        break;
    }
    cities.Add(input); // lägger till användaren inmatade cities i stringen
}
Console.WriteLine("Lista över inmatade cities");
foreach (var city in cities) // om användaren har är nöjd med antalet cities den inmatat så skrivs allt ut när användaren matar in exit
{
    Console.WriteLine(city);
}