Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

//Skapa en lista med filmnamn
List<string> listaNamn = ["Anna", " Björn", " Cecilia"];

//Skriv ut alla filmnamn
Console.WriteLine($"Nuvarande lista: {string.Join(",", listaNamn)}");

Console.WriteLine("Ange ett namn att lägga till:");
string namn = Console.ReadLine();

listaNamn.Add(namn);

Console.WriteLine($"Nuvarande lista: {string.Join(",", listaNamn)}");

Console.WriteLine("Ange ett namn att ta bort:");
string bort = Console.ReadLine();

//Om den finns ta bort den
if (listaNamn.Contains(bort))
{
    Console.WriteLine("Namnet finns");
    listaNamn.Remove("bort");
}
else
{
    Console.WriteLine("Namnet finns inte");

}

Console.WriteLine($"Nuvarande lista: {string.Join(",", listaNamn)}");

