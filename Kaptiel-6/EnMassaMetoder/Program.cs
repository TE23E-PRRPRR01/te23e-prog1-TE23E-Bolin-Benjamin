/***********************************************************
* *********************M A I N******************************
********************************************************* */

Console.ReadLine();
Console.WriteLine("Hej Metoder");

SägHejNamn("Valentin");
SägHejNamn("Johnny");
SägHejNamn("Benjamin");

KvadreraTal(3);


/***********************************************************
* *********************M E T O D E R************************
********************************************************* */

/// <summary>
/// Skriva ut hälsningar
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {}!");
}

/// <summary>
/// 
/// </summary>
/// <param name="tal"></param>
static void KvadreraTal(int tal)
{
    Console.WriteLine($"Tal i kvadrat = {tal * tal}");
}