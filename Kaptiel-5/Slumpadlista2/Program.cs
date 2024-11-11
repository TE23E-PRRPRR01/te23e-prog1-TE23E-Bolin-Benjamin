//Skapa lista med slumptal

/* *****************************************
**                  Main                  **
***************************************** */

//Validera användarens inmatning
Console.Clear();
Console.WriteLine("");

//Deklara variabler
//Skapa en lista för att spara de slumpade talen
List<int> listaSlumptal = [];



//Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal");

//Användaren matar in min-värde
int min = LäsInHeltal();
Console.WriteLine($"Lägsta slumtptal blir {min}");

//Användaren matar in min-värde
int max = LäsInHeltal();
Console.WriteLine($"Lägsta slumtptal blir {max}");


//Slumpa fram ett annat tal
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

/* *****************************************
**        Mina enga metoder               **
***************************************** */

static int LäsInHeltal()
{
    //Användaren matar in min-värde
    int heltal = 0;
    while (true)
    {
        //Fråga användaren hur många slumptal som skall skapas
        Console.WriteLine("Ange heltal: ");
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Du måste skriva ett heltal");
        }
    }
    return heltal;
}