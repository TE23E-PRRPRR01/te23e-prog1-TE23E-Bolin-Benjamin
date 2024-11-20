// for-loopar för att iterera över siffror, göra beräkningar och skapa mönster.
Console.Clear();

// Console.WriteLine("Ett program för att göra for-loopar för att iterera över siffror, göra beräkningar och skapa mönster.");

// Console.WriteLine("Ange startvärde");
// string mintext = Console.ReadLine();
// int min = 0;
// bool success = int.TryParse(mintext, out min);

// Console.WriteLine("Ange slutvärde");
// string maxText = Console.ReadLine();
// int max = 0;
// success = int.TryParse(maxText, out max);

// int summa = 0;

// for (int i = min; i < max + 1; i++)
// {
//     Console.WriteLine(i + 1);
//     summa = i;
// }

// Console.WriteLine($"Summan av siffrorna {min} till {max}är {summa}");

Console.WriteLine("Jämna siffror: ");

for (int i = 0; i < 11; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}

