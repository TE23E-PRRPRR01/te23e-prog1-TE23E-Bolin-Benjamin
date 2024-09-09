// Skapa ett program som implementerar valfria åldersregler.
// Välj 4 åldersgränser och associera dem med något som är tillåtet att göra vid den åldern.
Console.Clear();
Console.WriteLine("Program som berättar hur många minuter du får köra i en fotbollslag om man är lika gammal som dig");

// Användaren ska svara hur gammal han är
Console.Write("Hur gammal är du?: ");
string ålderText = Console.ReadLine(); // läs in texten
int ålder = int.Parse(ålderText); // konvertera texten till heltal

if (ålder == 6 || ålder == 7 || ålder == 8) // om man är 6, 7 eller 8 år gammal då..
{
    Console.WriteLine("Om du är 6-8 år så är det oficiellt 5 spelare på plan och man kör 30 minuter totalt");
}
else if (ålder == 9 || ålder == 10) // annars om man är 9 eller 10 år gammal då..
{
    Console.WriteLine("Om du är 9-10 år så är det oficiellt 7 spelare på plan och man kör 50 minuter totalt");
}
else if (ålder == 11 || ålder == 12) // annars om är 11 eller 12 år gammal då...
{
    Console.WriteLine("Om du är 11-12 år så är det oficiellt 9 spelare på plan och man kör 70 minuter totalt");
}
else if (ålder >= 13)  // annars om man är minst 13 år...
{
    Console.WriteLine("Om du är 13 år och uppåt så är det oficiellt 11 spelare på plan och man kör 90 minuter totalt");
}
if (ålder < 6) // Om man är yngre än 6 år (0-5) då...
{
    Console.WriteLine("Du är tyvärr för ung för att köra i en fotbollslag");
}