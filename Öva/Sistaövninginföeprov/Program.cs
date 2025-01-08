Console.ReadLine();

List<string> listlåtar = [];

int antal = 0;

while (true)
{
    Console.WriteLine("Ange antal låtar per session (2-6):");
    string låtar = Console.ReadLine();

    bool success = int.TryParse(låtar, out antal);
    if (success)
    {
        if ( antal < 2 || antal > 6)
        {
            Console.WriteLine("Fel! Var god att mata in ett heltal mellan 2 och 6.");
        }
        else
        {
            break;
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
3. Sök låtar efter artist
4. Avsluta
Välj ett alternativ:
""");
string val = Console.ReadLine();

if (val == "1")
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine($"Ange låt {i+1}:");
        string input = Console.ReadLine();
        listlåtar.Add(input);
    }
}
else if (val == "2")
{
    Console.WriteLine("Låtarna som finns i listan är:");
    foreach (var item in listlåtar)
    {
        Console.WriteLine($"-Låt: {item}");
    }
    
}
else if (val == "3")
{
    Console.WriteLine("Sök efter låt, skriv de första bokstäverna av låten:");
    string start = Console.ReadLine();
    System.Console.WriteLine("Resultat:");
    foreach (var item in listlåtar)
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
    Console.WriteLine("Fel! Var god att mata in ett tal mellan 1-4");
}
}