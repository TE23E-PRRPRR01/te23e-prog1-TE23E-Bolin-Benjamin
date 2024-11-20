using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("Skapa en loop som körs 10 gånger");


Console.Write("Skriv ditt namn: ");
string namn = Console.ReadLine();

while (true)
{
    Console.Write("Antal loopar: ");
    int antal = int.TryParse(Console.ReadLine());

    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($" {i}. {namn}");
    }

}
