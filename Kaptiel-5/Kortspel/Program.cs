//Ett annat exempel lista på 3 årtal
//List<int> årtal = [157, 1969, 1989];


//Hur man skapr och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur en kortlek!");

//skapa en lista kort¨
//List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjua", "Åtta", "Nia", "Tia", "Kneckt", "Dam", "Kung"];
//List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂬", "🂮"];
List<string> kortlek = ["😃", "*️⃣", "*️⃣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂬", "🂮"];

int antal = 5; 
while (antal > 0)
{
    //Slumpa index 0-12
int index = Random.Shared.Next(0,kortlek.Count);
//Console.WriteLine($"Det slumpade index = {index}");


//Plocka ut det sjunde kortet, index = 6
string kort = kortlek[index];

//Ta bort kortet ur kortleken
kortlek.RemoveAt(index);

//Skriv ut 7:e kortet
Console.WriteLine($"Det slumpade kortet är {kort}");

//Räkna ned
antal--;
}