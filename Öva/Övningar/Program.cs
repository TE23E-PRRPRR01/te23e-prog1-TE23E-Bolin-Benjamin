List<int> sakerlista = [];


sakerlista.Add(50);
sakerlista.Add(5);

int antal = sakerlista.Count();
Console.WriteLine($"Listan innehåller {antal} i listan");

for (var i = 0; i < antal; i++)
{
    Console.WriteLine($"Element {i+1} är: {sakerlista[i]}");
}

Console.WriteLine("Lägg till ett siffra i int listan");
sakerlista.Add(3);

static void Printalistan(List<int> lista)
{
    foreach (var element in lista)
{
    Console.WriteLine($"{element}");
}

}
Printalistan(sakerlista);


//Task bort alla element som börjar med en 5a

foreach (var item in sakerlista)
{
    string elementstring = "${item}";
    bool harvihittat = elementstring.StartsWith("5");
    Console.WriteLine($"{harvihittat} {elementstring}");
    if (harvihittat)
    {
        Console.WriteLine($"{item} har en 5a i början");
    }

}