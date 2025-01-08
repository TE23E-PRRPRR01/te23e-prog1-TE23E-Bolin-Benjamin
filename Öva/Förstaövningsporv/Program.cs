Console.Clear();

List<string> songlista = [];

int antal = 0;

while (true)
{
    Console.WriteLine("Ange antal låtar per session (2-6):");
    string inputstring = Console.ReadLine();

    bool success = int.TryParse(inputstring, out antal);
    if (success)
    {
        if (antal < 2 || antal > 6)
        {
            Console.WriteLine("Fel! Var god att mata in ett heltal mellan 2 och 6.");
        }
        else
        {
            break; //Kommer ut ur loopen
        }
    }
    else
    {
        Console.WriteLine("Fel! Var god att mata in ett heltal mellan 2 och 6.");
    }
}

while (true)
{

    Console.WriteLine("""
1. Lägg till låtar
2. Lista alla låtar
3. Sök efter låtar
4.Ta bort en låt
Välj ett alternativ:
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        for (var i = 0; i < antal; i++)
        {
            Console.WriteLine($"{i+1}. Ange låt");
            string song = Console.ReadLine();
            songlista.Add(song);
        }
    }
    else if (val == "2")
    {
        Console.WriteLine("Låtarna är:");
        foreach (var item in songlista)
        {
            Console.WriteLine($"{item}");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Hur börjar låtens namn?:");
        string songstart = Console.ReadLine();
        foreach (var item in songlista)
        {
            if (item.StartsWith(songstart))
            {
                Console.WriteLine($"{item}");
            }
           
        }
    }
        else if (val == "4")
    {
            Console.WriteLine("Ange låt som du ska ta bort");
            string song = Console.ReadLine();
            songlista.Remove(song);
    }
    else
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
}