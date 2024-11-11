// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

//Globala variabler
//En lista för heltal 
List<int> listaSlumptal = [];

//Be användaren ange antal slumpande tal
Console.WriteLine("Ange antal slumptal");
int antal = int.Parse(Console.ReadLine());

//Be användaren ange min och max slumptal
Console.WriteLine("Ange minSlumptal");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Ange maxSlumptal");
int max= int.Parse(Console.ReadLine());

//Loopa 5 ggr
for (int i = 0; i < antal; i++)
{
    //Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    //Lägg till slumptalet i lista
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}