/* *************************************************
 * Namn: SummeraTal
 * Beskrivning: Ett program för att summera tal
 * Datum: 2024-09-01
 *********************************************** */

Start();

int poäng = 0; // Poängräkning för utmaningen

while (true)
{
    Meny();
    string val = Console.ReadLine();

    if (val == "1")
    {
       int tal = Storlek();

        Tecken();

        int tal = Storlek();
    }
    else if (val == "2")
    {
        Storlek();

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "3")
    {
        Console.Write("Ange bredd: ");
        string inputBredd = Console.ReadLine();
        int bredd;
        while (!int.TryParse(inputBredd, out bredd))
        {
            Console.Write("Ange ett giltigt heltal: ");
            inputBredd = Console.ReadLine();
        }

        Console.Write("Ange höjd: ");
        string inputHöjd = Console.ReadLine();
        int höjd;
        while (!int.TryParse(inputHöjd, out höjd))
        {
            Console.Write("Ange ett giltigt heltal: ");
            inputHöjd = Console.ReadLine();
        }

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < bredd; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "4")
    {
        Console.Write("Ange höjd: ");
        string input = Console.ReadLine();
        int höjd;
        while (!int.TryParse(input, out höjd))
        {
            Console.Write("Ange ett giltigt heltal: ");
            input = Console.ReadLine();
        }

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < höjd - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "5")
    {
        Console.WriteLine("Ange figur att spara:");
        string figur = Console.ReadLine();
        File.WriteAllText("figur.txt", figur);
        Console.WriteLine("Figuren har sparats!");
    }
    else if (val == "6")
    {
        if (File.Exists("figur.txt"))
        {
            Console.WriteLine("Senast sparade figur:");
            Console.WriteLine(File.ReadAllText("figur.txt"));
        }
        else
        {
            Console.WriteLine("Ingen sparad figur hittades.");
        }
    }
    else if (val == "7")
    {
        Random slump = new Random();
        int korrektSvar = slump.Next(3, 10);

        Console.Write("Gissa storleken på figuren: ");
        string input = Console.ReadLine();
        int gissning;
        while (!int.TryParse(input, out gissning))
        {
            Console.Write("Ange ett giltigt heltal: ");
            input = Console.ReadLine();
        }

        if (gissning == korrektSvar)
        {
            Console.WriteLine("Rätt gissat! Du får 1 poäng.");
            poäng++;
        }
        else
        {
            Console.WriteLine($"Fel! Rätt svar var {korrektSvar}.");
        }

        Console.WriteLine($"Nuvarande poäng: {poäng}");

        for (int i = 0; i < korrektSvar; i++)
        {
            for (int j = 0; j < korrektSvar; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (val == "8")
    {
        kör = false;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen.");
    }

    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
    Console.ReadKey();
    Console.Clear();
}

/// <summary>
/// Start
/// </summary>
static void Start()
{
    Console.Clear();
    Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");
}

/// <summary>
/// Meny
/// </summary>
static void Meny()
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Skriv ut rektangel
    4. Skriv ut pyramid
    5. Spara figur
    6. Läs in sparad figur
    7. Utmaning: Gissa storleken
    8. Avsluta
    """);

    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// Ange storlek
/// </summary>
/// <returns></returns>
static int Storlek()
{
    Console.Write("Ange storlek: ");
    string input = Console.ReadLine();
    int tal;
    while (!int.TryParse(input, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        input = Console.ReadLine();
    }
    return tal;
}

/// <summary>
/// Tecken
/// </summary>
static void Tecken()
{
    Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

}