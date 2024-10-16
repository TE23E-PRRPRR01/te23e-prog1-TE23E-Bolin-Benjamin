//En liten morsekod app

Console.Clear();
Console.WriteLine("En liten morsekod app");
// För att kunna skriva svenska tecken
Console.InputEncoding = System.Text.Encoding.Unicode; 

//Två listor
List<string> alfabet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö",
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", ".----", "..---", 
            "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----"];

//Läs in en bokstav
Console.Write("Ange ett meddelande");
string meddelande = Console.ReadLine();

//Gå igenom meddelandet bokstav för bokstav (Loop)
foreach (char bokstav in meddelande)
{

    //Uppslag i alfavetet efter index
    int index = alfabet.IndexOf(bokstav.ToString());

    //Hittar morsetecken? (A-Ö)
    if (index >= 0)
    {
        //Console.WriteLine($"{bokstav} finns på index {index}");

        //Plocka ut morsetecknet för detta index
        string morsetecknen = morsekod[index];
        //Console.WriteLine($"{bokstav} är {morsetecknen}");
        Console.Write($"{morsetecknen} ");

        //Spela upp morse ljud-beep
        //Tex D = "-.."
        //Dvs loopa igenom morsetecknet
        foreach (char signal in morsetecknen)
        {
            if (signal== '.') //'.'
            {
                //100Hz, 200ms
                Console.Beep(1000, 50);
            }
            else //'-'
            {
                Console.Beep(1000, 150);
            }
        }
        //Paus i koden
        Thread.Sleep(100);
    }
    else
    {
        Console.WriteLine("?");
    }
}





