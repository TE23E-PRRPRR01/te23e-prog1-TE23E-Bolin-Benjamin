Console.Clear();
Console.WriteLine("Det här programmet räknar ut ditt BMI och ger en hälsofeedback baserat på ditt BMI.");
Console.WriteLine("Vad heter du?");

string namn = Console.ReadLine();


while (true)
{
    Console.WriteLine("Ange din vikt i kg");
    float vikt = float.Parse(Console.ReadLine());

    float bmi = 0.0f;

    if (vikt < 20 || vikt > 500)
    {
        Console.WriteLine("Vikten måste vara mellan 20 - 500kg");
        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
        if ("j" != Console.ReadLine())
        {
            break;
        }
    }

    Console.WriteLine("Ange din längd i cm");
    float längd = float.Parse(Console.ReadLine());

    if (längd < 50 || längd > 300)
    {
        Console.WriteLine("Längden måste vara mellan 50 - 300cm");
        Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
        if ("j" != Console.ReadLine())
        {
            break;
        }
    }

    bmi = vikt / (längd / 100 * längd / 100);

    string typ = "";

    if (bmi < 18.5)
    {
        typ = "Undervikt";
    }
    else if (bmi >= 18.5 && bmi <= 24.9)
    {
        typ = "normalvikt";
    }
    else if (bmi >= 25.0 && bmi <= 29.9)
    {
        typ = "övervikt";
    }
    else if (bmi >= 30 && bmi <= 34.9)
    {
        typ = "Fetma klass 1";
    }
    else if (bmi >= 35 && bmi <= 39.9)
    {
        typ = "Fetma klass 2";
    }
    else if (bmi >= 40)
    {
        typ = "Fetma klass 3";
    }

    Console.WriteLine($"{namn}, ditt BMI är {bmi} och du är klassificerad som {typ}.");

    for (int c = 0; c < 5; c++)
    {
      Console.WriteLine(c);  
    }
    Console.WriteLine("Vill du göra en ny beräkning? (j/n)");
    if ("j" != Console.ReadLine())
    {
        break;
    }
}


