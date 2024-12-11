Console.Clear();
Console.WriteLine("Filmregister");

//Lista för att lagra filmer
List<string> listafilmer = [];

//Be användaren ange ett antal
Console.Write("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Var gof att mata in ett heltal.");
    }
}

//Programloop
while (true)
{
    Console.WriteLine();
    //visa en meny
    Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ:
""");
    string val = Console.ReadLine();

    //Hanterar med valet
    if (val == "1")
    {
        Console.WriteLine();
        //Lägg till filmer i listan
        for (int i = 0; i < antal; i++)
        {
            Console.Write("Ange en film att lägga till: ");
            string film = Console.ReadLine();
            listafilmer.Add(film);
        }
    }
    else if (val == "2")
    {
        Console.WriteLine();
        //Skriv ut alla filmer
        foreach (var filmnamn in listafilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine();
        //Sök en film
        Console.WriteLine("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listafilmer)
        {
            // Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filmnamn);

            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine();
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Fel val. Försök igen!");
    }

}

