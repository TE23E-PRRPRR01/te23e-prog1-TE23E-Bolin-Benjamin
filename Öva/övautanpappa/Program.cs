Console.Clear();
Console.WriteLine("Välkommen till Hushållsbudgetkalkylatorn!");
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

Console.WriteLine("Ange din månadslön");
float lön = float.Parse(Console.ReadLine());

Console.WriteLine("Ange dina utgifter för boende");
float boende = float.Parse(Console.ReadLine());

Console.WriteLine("Ange dina utgifter för mat");
float mat = float.Parse(Console.ReadLine());

Console.WriteLine("Ange dina utgifter för transport");
float transport = float.Parse(Console.ReadLine());

Console.WriteLine("Ange dina utgifter för utgifter");
float utgifter = float.Parse(Console.ReadLine());

float kvar = 0;
float kvarProcent = 100;

kvar = lön - boende - mat - transport - utgifter; // #todo ej neg kvar
if (kvar < 0.0)
{
    Console.WriteLine($"Du går back {kvar} varje månad");


}
else
{
    Console.WriteLine($"Du har {kvar}kr efter alla utgifter");
/*
    Console.WriteLine("Procentuell fördelning av utgifter:");
    float procent = (boende / lön) * 100;
    Console.WriteLine($"-Boende är {procent} av din lön");

    procent = (mat / lön) * 100;
    Console.WriteLine($"-Mat är {procent} av din lön");

    procent = (transport / lön) * 100;
    Console.WriteLine($"-Mat är {procent} av din lön");

    procent = (utgifter / lön) * 100;
    Console.WriteLine($"-Mat är {procent} av din lön");*/
    kvarProcent = kvarProcent - calculatePercentageAndPrint(boende, "boende", lön);    
    kvarProcent = kvarProcent - calculatePercentageAndPrint(mat, "mat", lön);    
    kvarProcent = kvarProcent - calculatePercentageAndPrint(transport, "transport", lön);
    kvarProcent = kvarProcent - calculatePercentageAndPrint(utgifter, "utgifter", lön);
    Console.WriteLine($"Du sparar varje månad {kvarProcent}% av din lön");
}

static float calculatePercentageAndPrint(float cost, string costString, float salory ) //egen funktion för beräkning retunerar float
{
    float procent = (cost / salory) * 100;
    Console.WriteLine($"-{costString} är {procent}% av din lön");
    return procent;
}
