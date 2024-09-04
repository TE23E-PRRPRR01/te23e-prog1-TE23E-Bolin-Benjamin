// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en ASCii art
Console.WriteLine($"""
                                    $"   *.      
              d$$$$$$$P"                  $    J
                  ^$.                     4r  "
                  d"b                    .db
                 P   $                  e" $
        ..ec.. ."     *.              zP   $.zec..
    .^        3*b.     *.           .P" .@"4F      "4
  ."         d"  ^b.    *c        .$"  d"   $         %
 /          P      $.    "c      d"   @     3r         3
         .eE........$r===e$$$$eeP    J       *..        b
$       $$$$$       $   4$$$$$$$     F       d$$$.      4
$       $$$$$       $   4$$$$$$$     L       *$$$"      4
4         "      ""3P ===$$$$$$"     3                  P
 *                 $       "+"        b                J
  ".             .P                    %.             @
    %.         z*"                      ^%.        .r"
       "*==*""                             ^"*==*""   Gilo94'
""");

Console.Write("Är det en cykel?(Y/N) ");
string answer = Console.ReadLine().ToUpper();

// Kolla om svar är ja eller nej
if (answer == "Y")
{ // Y = Yes
    Console.Write("Skulle du våga cykla? (Y/N) ");
    answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        Console.Write("Skulle du använda hjälm? (Y/N) ");
        answer = Console.ReadLine().ToUpper();
        if ( answer == "Y")
        {
             Console.WriteLine("Good boy!");
        }
        else
        {
             Console.WriteLine("Bad boy!");
        }
    }
    else
    {
        Console.WriteLine("Bad boy!");
    }
}
else
{ // N = No
    Console.Write("Du borde testa! (Y/N) ");
    answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        Console.WriteLine("Good boy");
    }
    else
    {
        Console.WriteLine("Bad boy");
    }
}