using System;

int[] poleCisel = {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2};
int[] poleCiselNove = new int[poleCisel.Length];
int[] poleCiselSerazene = new int[poleCisel.Length];
;

Console.WriteLine("Vypsat obsah pole");

//vypsat obsah pole
Console.WriteLine(string.Join("\t", poleCisel));


Console.WriteLine("Nové pole s upravenými čísly");
//ze záporných kladná a k nule přičíst index 
for (int i = 0; i<poleCisel.Length; i++)
{
    if (poleCisel[i] < 0)
    {
        poleCiselNove[i] = Math.Abs(poleCisel[i]);
    }
    else if (poleCisel[i] == 0)
    {
        poleCiselNove[i] = i;
    }
    else
    {
        poleCiselNove[i] = poleCisel[i];
    }
}
Console.WriteLine(string.Join("\t", poleCiselNove));


//Najít nejvyšší číslo

int nejvyssiCislo = poleCisel[0];
for (int i = 0; i < poleCisel.Length; i++)
{
    if (poleCisel[i] > nejvyssiCislo)
    {
        nejvyssiCislo = poleCisel[i];
    }
}
Console.WriteLine($"Nejvyšší číslo je: " + nejvyssiCislo);

//seřadit čísla od nejmenšího po největší
int temp;
for (int i = 0; i < poleCisel.Length; i++)
{
    for (int j = i + 1; j < poleCisel.Length; j++) {  //bubbling algorhitm, vnořený loop porovnává současné číslo s číslem následujícím a pokud je větší, přehodí si místa.

        if (poleCisel[i] > poleCisel[j])
    {
        temp = poleCisel[i];
        poleCisel[i] = poleCisel[j];
        poleCisel[j] = temp;
    }
        poleCiselSerazene[j] = poleCisel[j];
        }
    poleCiselSerazene[i] = poleCisel[i];
}
Console.WriteLine("Seřazená čísla");
Console.WriteLine(string.Join("\t",poleCiselSerazene));

