Console.Clear();

List<string> låtlista = [];


int antal = 0;

while (true)
{
    Console.WriteLine("*** Musikregistret ***");
    Console.WriteLine("Ange antal låtar per session (2-6):");
    string låtar = Console.ReadLine();

    bool success = int.TryParse(låtar, out antal);
    if (success)
    {
        break;
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
3. Sök låtar efter artist
4. Avsluta
Välj ett alternativ:
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        for (var i = 0; i < antal; i++)
        {
            Console.WriteLine($"{i + 1}. Lägg till en låt i listan");
            string läggtill = Console.ReadLine();
            låtlista.Add(läggtill);
        }
    }
    else if (val == "2")
    {
        Console.WriteLine("Låtarna är:");
        foreach (var item in låtlista)
        {
            Console.WriteLine($"{item}");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Sök efter låt");
        string start = Console.ReadLine();
        foreach (var item in låtlista)
        {
            if (item.StartsWith(start))
            {
                Console.WriteLine($"{item}");
            }
        }
    }
    else if (val == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Välj mellan valen");
    }
}