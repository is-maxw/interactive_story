using System;

Console.WriteLine("Hej! Vill du hänga efter middagen?");

string meet = Console.ReadLine();


if (meet == "ja")
{
    Console.WriteLine("Perfekt! Ska vi ses runt 3?");

    string when = Console.ReadLine();
    
    if (when == "ja")
    {
        Console.WriteLine("Vad bra! Då ses vi då!");
    }
    else if (when == "nej")
    {
        Console.WriteLine("Nehä. Då får det bli vid 4 istället.");
    }


}
else if (meet == "nej")
{
    Console.WriteLine("Jaha. Ska du göra något annat då?");

    string todo = Console.ReadLine();

    if (todo == "ja")
    {
        Console.WriteLine("Jaha, men kan vi ses imorgon då?");

        string tomorrow = Console.ReadLine();

        if (tomorrow == "ja")
        {
            Console.WriteLine("Ok! Då ses vi imorgon!");
        }
        else if (tomorrow == "nej")

        Console.WriteLine("Då får vi se någon annan dag om det passar då. Hejdå");
    }
    else if (todo == "nej")
    {
        Console.WriteLine("Nehä, jag gissar på att du bara vill vara ensam då. Ha det så bra.");
    }

}

Console.ReadLine();

