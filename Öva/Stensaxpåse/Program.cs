// Spelet sten, sax, påse, ödla, Spock
Console.Clear();
Console.WriteLine("Välkommen till Sten, sax, påse, ödla, Spock!");
Console.WriteLine("""
Spelets regler:
Sten krossar sax
Sten krossar ödla
Sax klipper papper
Sax halshugger ödla
Påse täcker sten
Påse fångar Spock
Ödla äter papper
Ödla förgiftar Spock
Spock krossar sax
Spock smälter sten
""");

// Programloop
while (true)
{
    // Slumpa fram datorns val
    int slumptal = Random.Shared.Next(1, 5);
    string svarD = "";

    if (slumptal == 1)
    {
        svarD = "sten";
    }
    else if (slumptal == 2)
    {
        svarD = "sax";
    }
    else if (slumptal == 3)
    {
        svarD = "påse";
    }
    else if (slumptal == 4)
    {
        svarD = "ödla";
    }
    else if (slumptal == 5)
    {
        svarD = "spock";
    }

    // Fråga användaren om val
    Console.WriteLine("Välj: sten, sax, påse, ödla eller Spock: ");
    string svarA = Console.ReadLine.();
    svarA = svarA.ToLower().Trim(); //på en string gör vi småbokstäver och tar bort mellanslag


    // Jämför användarens och datorns val
    Console.WriteLine($"Dator säger {svarD} och du säger {svarA}");

    // Vem vinner?

    // Vill användaren spela igen?

    // Avsluta programmet
}

static float calculatePercentageAndPrint(float cost, string costString, float salory ) //egen funktion för beräkning retunerar float
{
    float procent = (cost / salory) * 100;
    Console.WriteLine($"-{costString} är {procent}% av din lön");
    return procent;
}