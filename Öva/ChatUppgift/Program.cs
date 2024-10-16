using System.Numerics;

Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut det totala priset för en vara inklusive moms.
Momsen räknas ut baserat på varans pris exklusive moms.
""");
Console.WriteLine("Vad är ditt namn?");

string namn = Console.ReadLine();
double varan = 0;


while (true)
{
    Console.WriteLine("Ange priset på varan exklusive moms i kronor:");
    varan = int.Parse(Console.ReadLine());
    if (varan < 1 || varan > 10000)
    {
        Console.WriteLine($"{namn}, priset måste vara mellan 1:- och 10000:-.");
        Console.WriteLine("Vill du gör en ny beräkning? (j/n)");
        if ("j" != Console.ReadLine())
        {
            break;
        }
    }
    else
    {
        double total = 0.0f;
        int procent = 0;

        if (varan >= 0 && varan <= 200)
        {
            procent = 6;
        }
        else if (varan >= 201 && varan <= 1000)
        {
            procent = 12;
        }
        else if (varan > 1000)
        {
            procent = 25;
        }

        total = varan * (100 + procent) / 100;

        Console.WriteLine($"Det totala priset blir {total} kr. Uträkning baserad på priset {varan} kr och momssatsen {procent}%.");
        Console.WriteLine("Vill du gör en ny beräkning? (j/n)");
        if ("j" != Console.ReadLine())
        {
            break;
        }
    }
}


