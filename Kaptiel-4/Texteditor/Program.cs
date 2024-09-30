using System.IO;

Console.Clear();
Console.WriteLine("Texteditor");

string val = "";

while (true)
{
    // Menyn som visas för användaren
    Console.WriteLine(@"Välj ett av följande alternativ: 
    1. Skriv till fil    
    2. Läs från fil    
    3. Avsluta programmet");

    // Läs in användarens val
    Console.Write("Ditt val: ");
    val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        // Användaren skriver in text för att spara i fil
        Console.Write("Skriv in en text: ");
        string text = Console.ReadLine();

        // Skriv texten till filen "text.txt"
        File.WriteAllText("text.txt", text);

        // Bekräftelse till användaren
        Console.WriteLine("Texten har sparats i filen text.txt");
    }
    else if (val == "2")
    {
        // Läs texten från filen "text.txt"
        if (File.Exists("text.txt"))
        {
            string text = File.ReadAllText("text.txt");

            // Visa texten som finns i filen
            Console.WriteLine("Texten i filen är:");
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Filen text.txt hittades inte.");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag.");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inte ett giltigt alternativ.");
    }
}