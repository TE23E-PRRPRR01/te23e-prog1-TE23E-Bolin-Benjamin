// Program för att räkna ut kostnaden för att hyra en bil
Console.Clear();
Console.WriteLine("Program för att räkna ut kostnaden för att hyra en bil");

// Läsa in hur mycket mil bilen har kört
Console.Write("Ange hur mycket mil bilen har kört: ");
int mil = int.Parse(Console.ReadLine());

// Läsa in hur många dagar användaren ska hyra bilen
Console.Write("Ange hur många dagar du vill hyra bilen: ");
int dagar = int.Parse(Console.ReadLine());

// Räkna ut hur mycket det kommer att kosta för att hyra bilen
double pris = mil * 5 + dagar * 100 + 500;

// Berätta hur mycket kronor det kommer att kosta
Console.WriteLine($"Då kommer bilen att kosta dig {pris} kronor");