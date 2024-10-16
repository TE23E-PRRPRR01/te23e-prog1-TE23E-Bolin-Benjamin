Console.Clear();
Console.WriteLine("Skriv in ämnens namn");
string subject = Console.ReadLine();

Console.WriteLine($"Skriv in ditt betyg för {subject}, A, B eller C");
string grade = Console.ReadLine();

float summa = 0.0f;
float average = 0.0f;
int counter = 1; //räknare
Console.WriteLine($"Subject is {subject} and lenght is {subject.Length}");
while (true)
{
    
    grade = grade.ToUpper();
    if (grade == "A")
    {
        summa = summa + 5;
    }
    else if (grade == "B")
    {
        summa = summa + 4;
    }
    else if (grade == "C")
    {
        summa = summa + 3;
    }

    Console.WriteLine("Skriv in ämnens namn");
    subject = Console.ReadLine();

    if (subject == "esc")
    {
        break;
    }
    counter = counter + 1;
    Console.WriteLine($"Skriv in ditt betyg för {subject}");
    grade = Console.ReadLine();

}

average = summa / counter;
Console.WriteLine($"Ditt medelbetyg är {average} = {summa}/{counter}");

