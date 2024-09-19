int poäng = 0;

Console.WriteLine("Fråga 1: Vad är Tyler, The Creators mest populära album i streams?");
Console.WriteLine("a) IGOR");
Console.WriteLine("b) Flower Boy");
Console.WriteLine("c) CALL ME IF YOU GET LOST");
string svar1 = Console.ReadLine();

if (svar1 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 2: Vilket år släppte Frank Ocean \"Blonde\"?");
Console.WriteLine("a) 2017");
Console.WriteLine("b) 2016");
Console.WriteLine("c) 2015");
string svar2 = Console.ReadLine();

if (svar2 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 3: Vilken stad fokuserar Kendrick Lamar på i albumet \"good kid, m.A.A.d city\"?");
Console.WriteLine("a) New York");
Console.WriteLine("b) Compton");
Console.WriteLine("c) Atlanta");
string svar3 = Console.ReadLine();

if (svar3 == "b")
{
    poäng++;
}

Console.WriteLine("Fråga 4: Vilket av Kanye Wests album anses vara mest experimentellt?");
Console.WriteLine("a) The Life of Pablo");
Console.WriteLine("b) 808s & Heartbreak");
Console.WriteLine("c) Yeezus");
string svar4 = Console.ReadLine();

if (svar4 == "c")
{
    poäng++;
}

Console.WriteLine("Fråga 5: Vilket av Drakes album innehåller hitlåtarna \"Hotline Bling\" och \"One Dance\"?");
Console.WriteLine("a) Views");
Console.WriteLine("b) More Life");
Console.WriteLine("c) Scorpion");
string svar5 = Console.ReadLine();

if (svar5 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 6: När släppte A$AP ROCKY sitt sista album \"TESTING\"?");
Console.WriteLine("a) 2018");
Console.WriteLine("b) 2019");
Console.WriteLine("c) 2017");
string svar6 = Console.ReadLine();


if (svar6 == "a")
{
    poäng++;
}

Console.WriteLine("Fråga 7: Vad är Ken Carsons mest populära låt i streams?");
Console.WriteLine("a) Freestyle 2");
Console.WriteLine("b) Fighting My Demons");
Console.WriteLine("c) Yale");
string svar7 = Console.ReadLine();


if (svar7 == "c")
{
    poäng++;
}

Console.WriteLine("Fråga 8: Genom vilket sätt släppte Frank Ocean albumet \"Endless\" online?");
Console.WriteLine("a) En ljudbok");
Console.WriteLine("b) En live-streamad video");
Console.WriteLine("c) En exklusiv CD-skiva");
string svar8 = Console.ReadLine();


if (svar8 == "b")
{
    poäng++;
}

Console.WriteLine("Grattis, du fick " + poäng + " rätt av 8!");
Console.ReadLine();