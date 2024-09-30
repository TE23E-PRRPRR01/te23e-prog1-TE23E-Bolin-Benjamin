// Spelet - frågesport 

Console.Clear();
Console.WriteLine("Spelet - frågesport");

// En variabel för att hålla koll på antal gissningar
int poäng = 0;

// Fråga om användarens namn
Console.Write("Hej! Vad heter du? ");
string namn = Console.ReadLine();

Console.Clear();

string svar = "";

// Upprepning - loop
while (true)
{
    while (true) // För att repetera fråga 1 om användaren skriver in något annat än a,b eller c
    {
        // Fråga 1
        Console.Write("""
Fråga 1: Vad är världens äldsta huvudstad?
a) Stockholm
b) New Delhi
c) Damaskus
Skriv ditt svar (a, b eller c): 
""");
        svar = Console.ReadLine().ToLower();
        if (svar == "c")
        {
            Console.WriteLine("Rätt Svar!");
            poäng++; //Räkna upp 1 poäng
            break;
        }
        else if (svar == "a" || svar == "b")
        {
            Console.WriteLine("Fel Svar!");
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Jag förstod inte, svara ett svar från alternativen");
        }
    }


    Console.Clear();


    while (true)
    {
        Console.Write("""
Fråga 2: Vem är världens rikaste människa
a) Elon Musk
b) Jeff Bezos
c) Mark Zuckerberg
Skriv ditt svar (a, b eller c): 
""");
    svar = Console.ReadLine().ToLower();
    if (svar == "a")
    {
        Console.WriteLine("Rätt svar!");
        poäng++;
        break;
    }
    else if (svar == "b" || svar == "c")
    {
        Console.WriteLine("Fel Svar!");
        break;
    }
    else
    {
        Console.WriteLine("Jag förstod inte, svara ett svar från alternativen");
    }
 
    }
    
    Console.Clear();


    while (true)
    {

    Console.Write("""
Fråga 3: Vilket år föddes Drottning Elizabeth
a) 1940
b) 1914
c) 1926
Skriv ditt svar (a, b eller c): 
""");
    svar = Console.ReadLine().ToLower();
    if (svar == "c")
    {
        Console.WriteLine("Rätt Svar!");
        poäng++;
    }
     else if (svar == "a" || svar == "b")
    {
        Console.WriteLine("Fel Svar!");
        break;
    }
    else
    {
        Console.WriteLine("Jag förstod inte, svara ett svar från alternativen");
    }
    }

Console.Clear();


     while (true)
     {

    Console.Write("""
Fråga 4: Vilket år startade NTI Stockholm Gymnasiet?
a) 2002
b) 1999
c) 2009
Skriv ditt svar (a, b eller c): 
""");
    svar = Console.ReadLine().ToLower();
    if (svar == "a")
    {
        Console.WriteLine("Rätt Svar!");
        poäng++;
    }
    else if (svar == "b" || svar == "c")
    {
        Console.WriteLine("Fel Svar!");
    }
    else
    {
        Console.WriteLine("Jag förstod inte, svara ett svar från alternativen");
    }
    }

    Console.Clear();

    if (poäng == 0 || poäng == 1)
    {
        Console.WriteLine($"Du fick rätt på {poäng} frågor. Bättre lycka nästa gång {namn}");
    }
    else if (poäng == 2 || poäng == 3)
    {
        Console.WriteLine($"Du fick rätt på {poäng} frågor. Bra jobbat {namn}!");
    }
    else // om man fick full pott
    {
        Console.WriteLine($"Du fick rätt på {poäng} frågor. {namn}, du är en riktig quiz-mästare!");
    }


    // Använd en loop för att få spelet att börja om när man spelat klart
    Console.Write($"{namn}, vill du spela igen? (j/n): ");
    svar = Console.ReadLine();
    if (svar == "n")
    {
        break;
    }

    Console.Clear();
}