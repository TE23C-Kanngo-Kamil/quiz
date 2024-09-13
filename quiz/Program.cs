int poäng = 0;

Console.WriteLine("Fråga 1: Vad är huvudstaden i Norge?");
Console.WriteLine("a) Oslo");
Console.WriteLine("b) Bergen");
Console.WriteLine("c) Trondheim");
string svar1 = Console.ReadLine();

if (svar1 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 2: Vilket år bröt första världskriget ut?");
Console.WriteLine("a) 1912");
Console.WriteLine("b) 1914");
Console.WriteLine("c) 1916");
string svar2 = Console.ReadLine();

if (svar2 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 3: Vilken är den största kontinenten?");
Console.WriteLine("a) Afrika");
Console.WriteLine("b) Asien");
Console.WriteLine("c) Europa");
string svar3 = Console.ReadLine();

if (svar3 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 4: Vad är den minsta planeten i vårt solsystem?");
Console.WriteLine("a) Venus");
Console.WriteLine("b) Merkurius");
Console.WriteLine("c) Mars");
string svar4 = Console.ReadLine();

if (svar4 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 5: Vem var USA:s första president?");
Console.WriteLine("a) Thomas Jefferson");
Console.WriteLine("b) George Washington");
Console.WriteLine("c) Abraham Lincoln");
string svar5 = Console.ReadLine();

if (svar5 == "b")
{
    poäng++;
}

Console.WriteLine("Grattis, du fick " + poäng + " rätt av 5.");
Console.ReadLine();