using System.ComponentModel.DataAnnotations.Schema;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

List<string> names = ["Anna", "Björn", "Cecilia", "Daniel", "Eva"];
Console.WriteLine($"Mina kompisar är: {string.Join(", ", names)}");
Console.WriteLine("Första namnet är " + names.First());
Console.WriteLine("Sista namnet är " + names.Last());

int size = names.Count();

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]}");
}

//List<int> numbers = [1000, 1001, 1002, 1005, 1006];
//Console.WriteLine($"Fem viktiga årtal är: {string.Join(", ", numbers)}");


List<string> drickor = ["Cola", "Te", "Pepsi", "Fanta", "Vatten"];

static void printadrickor(List<string> drickor)
{
    Console.WriteLine("Mina favoritdrycker är:");
    int length = drickor.Count();
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{i + 1}. {drickor[i]}");
    }

}

printadrickor(drickor);

Console.WriteLine("Lägg till din favorit dryck:");
string nydricka = Console.ReadLine();
drickor.Add(nydricka);
printadrickor(drickor);

List<int> years = [1492, 1776];

static void printyears(List<int> myyears)
{
    int length = myyears.Count();
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{i + 1}. {myyears[i]}");
    }
}

printyears(years);

Console.WriteLine("Lägg till ett år:");
int y = int.TryParse(Console.ReadLine());

years.Add(y);

printyears(years);

