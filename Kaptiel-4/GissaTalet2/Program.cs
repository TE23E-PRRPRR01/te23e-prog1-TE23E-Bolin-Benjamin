//Spelet - gissa ett slumptal 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal 1-100");

//En variabel för att hålla koll på antal gissningar
int antal = 0;


//Fråga användare om min och max värdet för talet
Console.Write("Ange minimum värdet för slumptalet");
int minVärde = int.Parse(Console.ReadLine());

Console.Write("Ange maximum värde för slumptalet");
int maxVärde = int.Parse(Console.ReadLine());

//Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(minVärde, maxVärde + 1);

//Upprepning - loop
while (true)
{
    //Ställ fråga till användaren
    Console.Write($"Gissa ett tal ({minVärde}-{maxVärde}):");
    int gissning = int.Parse(Console.ReadLine());

    //Räkna upp antal med 1
    antal++;

    //kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissa {antal} gångert!");
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }
    
    
    //Vill användare gissa en gång till?
     Console.Write("Vill du gissa en gång till? (j/n)");
     string svar = Console.ReadLine();
     if (svar == "n")
     {
        break;
     }
     
}

//Slut på spelet
Console.WriteLine("Slut!, Tack för att du spalade mitt fina spel!");