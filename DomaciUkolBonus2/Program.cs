int[] pole = { 3, 1, 9, 7, 5 };

int nejnizsiCislo = pole[0];
int nejvyssiCislo = pole[0];
int soucet = 0;

for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] > nejvyssiCislo)
    {
        nejvyssiCislo = pole[i];
    }
}

for (int i = 0; i < pole.Length; i++)
{
    if (pole[i] < nejnizsiCislo)
    {
        nejnizsiCislo = pole[i];
    }
}
for (int i = 0; i < pole.Length; i++)
{
    soucet += pole[i];
}
int soucetNejvyssi = soucet - nejnizsiCislo;
int soucetNejnizsi = soucet - nejvyssiCislo;
Console.Write($"Součet n-1 nejvyšších čísel: " + soucetNejvyssi + " A součet n-1 nejnižších čísel: " + soucetNejnizsi);