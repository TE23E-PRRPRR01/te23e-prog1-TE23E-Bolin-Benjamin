
/***********************************************************
* ***************************M A I N************************
********************************************************* */

Console.Clear();
Console.WriteLine("Hej metoder");

//Anropa/använd metod
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

//Anropa metoden visameny
VisaMeny();

//Anropa metod Skr/***********************************************************
* *********************M E T O D E R************************
********************************************************* */iva ut
SkrivaUt();

/***********************************************************
* *********************M E T O D E R************************
********************************************************* */

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig");   
}

/// <summary>
/// Metod för att visa en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1: Lägg till uppgift
    2. Ta bort uppgift
    3. Skirv ut alla uppgifter
    4. Avsluta
    """);
}

/// <summary>
/// Valfri metod
/// </summary>
static void SkrivaUt()
{
    Console.WriteLine("Detta är en valfri uppgift!");
}