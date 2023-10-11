Console.WriteLine("Zadej počet schodů");

int pocetSchodu;
while (!int.TryParse(Console.ReadLine(), out pocetSchodu) || pocetSchodu < 1)
{
    Console.WriteLine("Zadej celé kladné číslo");
}

Console.WriteLine("Schody:");

for (int i = 0; i < pocetSchodu; i++)
{  
 
    for (int j = 0; j < i+1; j++)
    {
        Console.Write("#");
    }
    for (int k = 0; k < (pocetSchodu - i); k++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("");
}


