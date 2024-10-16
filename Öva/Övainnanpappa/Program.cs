Console.Clear();
Console.WriteLine("Välkommen till programmet för beräkning av elkostnad!");


while (true)
{
    Console.WriteLine("Ange din elförbrukning i kWh:");
    double förbruk = float.Parse(Console.ReadLine());

    double kostnad = 0;

    double pris = 0;

    if (förbruk < 1000 || förbruk > 50000)
    {
        Console.WriteLine("Förbrukningen måste vara mellan 1000 kWh och 50000 kWh.");
        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
        if ("j" != Console.ReadLine())
        {
            break;
        }
    }
    else
    {
        if (förbruk >= 5000)
        {
            pris = 1.5;
        }
        else if (förbruk >= 5001 || förbruk <= 150000)
        {
            pris = 2.2;
        }
        else if (förbruk >= 15001)
        {
            pris = 3;
        }

        kostnad = förbruk * pris;
    }

    Console.WriteLine($"Din elkostnad blir {kostnad} kr. Beräkningen är baserad på en förbrukning på {förbruk} kWh och ett elpris på {pris} kr/kWh.");

    Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
    if ("j" != Console.ReadLine())
    {
        break;
    }
}

