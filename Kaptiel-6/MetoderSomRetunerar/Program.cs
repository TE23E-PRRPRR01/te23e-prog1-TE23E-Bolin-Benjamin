/***********************************************************
* *********************M A I N******************************
********************************************************* */
//Använd metoder här!
int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

string ord = "Hej";
Console.WriteLine($"Här är ordet omvänt {VändText(ord)}");



double slut = Dela(6, 3);
Console.WriteLine($"6/3 = {Dela(6, 3)}");


string text1 = "Hej";
string text2 = "Hejsan";
Console.WriteLine($"Längsta ordet är {Ord("Hej", "Hejsan")}");

Console.WriteLine("Ange ett tal: ");
int nyTal = LäsInHeltal();

Console.WriteLine("Ange ett tal: ");
int nyTal1 = LäsInHeltal();
/***********************************************************
* *********************M E T O D E R************************
********************************************************* */
//Skapa metoder här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) //Signatur
{
    int summa = tal1 + tal2;
    return summa;

}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>

static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}


/// <summary>
/// Multiplicerar tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dela(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}


static string Ord(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}


/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det krashchar)
/// </summary>
static int LäsInHeltal()
{

    int tal = 0;
    
    while (true)
    {
        string textSOmBlirTal = Console.ReadLine();

        //Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSOmBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel! VG ange ett heltal");
        }
    }

    return tal;
}