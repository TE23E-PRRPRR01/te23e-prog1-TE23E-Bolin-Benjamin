// Program som informerar användaren om deras BMI (Body Mass Index)
Console.Clear();
Console.WriteLine("Program som informerar användaren om deras BMI (Body Mass Index)");

// Läsa in vikten i kilogram
Console.Write("Ange din vikt i kilogram: ");
double viktKilogram = double.Parse(Console.ReadLine());

// Läsa in längd i meter
Console.Write("Ange din längd i meter: ");
double längdMeter = double.Parse(Console.ReadLine());

// Räkna ut användarens BMI
double BMI = viktKilogram / (längdMeter * längdMeter);

// Berätta till användaren om vad deras BMI är
Console.WriteLine($"Din BMI är {BMI:00.0}");