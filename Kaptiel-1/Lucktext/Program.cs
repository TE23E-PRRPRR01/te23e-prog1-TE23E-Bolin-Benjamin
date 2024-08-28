using System.Text.Json.Serialization;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("En rolig lucktext");
Console.Write("Ange ditt namn");
String namn = Console.ReadLine();

if (namn == "")
{
    Console.WriteLine("Du glömnde att fylla i namnet");
}
else
{
    Console.Write("Vad är ditt favorit djur?");
String djur = Console.ReadLine();
Console.Write("Vad är din favorit färg?");
String färg = Console.ReadLine();
Console.WriteLine("Vad brukar du säga när du är arg?");
String arg = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine($"Mitt namn är {namn} och jag gillar {djur} som är {färg} samt att jag brukar säga {arg} till folk på gatan" );
}

