Console.Clear();
Console.WriteLine("Slumpa Stader!");

//skapa en lista kort¨
List<string> städer = ["Köping", "NorrKöping", "SöderKöping", "Malmö", "Norrtäljer", "Stockholm", "Split", "Sarajevo", "Göteborg", "Bålsta"];

int antal = 2;
while (antal > 0)
{

    int index = Random.Shared.Next(0, 9);
    //Console.WriteLine($"Det slumpade index = {index}");

    string Stad = städer[index];


    Console.WriteLine($"Det slumpade Stad är {Stad}");


    antal--;
}