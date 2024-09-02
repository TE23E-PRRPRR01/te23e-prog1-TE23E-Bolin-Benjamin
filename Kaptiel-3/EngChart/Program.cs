// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en ASCii art
Console.WriteLine($"""
                       -   ,--_--.
               -           \      `.
                      -     "-_ _   \
     -                         / F   )
                   -     -    / / `--'
              -              / /
                   -        / /
            -            __/ /
                        /,-pJ
           -        _--"-L ||
                  ,"      "//
     -           /  ,-"-".//\
                /  (     // J____
               J  (     // L/----\
   .           F (     //__//^---'
     `     ___J  F    '----| |
  `       J---|  F         ) F
    `. `   `--J  L        )  F
    .   .`     L J       )  F
       .  .    J  \    ,"  F
         .  `.` \  "--"  ,"
    hs      ` ``."-____-"
 """);

 Console.Write("Does it move?(Y/N) ");
 string answer = Console.ReadLine();
 
 // Kolla om svar är ja eller nej
 if (answer == "Y")
 { // Y = Yes
    Console.Write("Should it? (Y/N) ");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Please use Duct Tape!");
    }
 }
 else
 { // N = No
    Console.Write("Should it? (Y/N) ");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Please use WD-40!");
    }
    else
    {
        Console.WriteLine("No Problem!");
    }
 }