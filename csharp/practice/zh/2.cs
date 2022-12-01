using System;

string[,] array = new string[3, 3] {
                                  { "Név", "Matek", "Fizika" },
                                  { "Pista", "1", "4" },
                                  { "Béla", "3", "3" }
                                };

int vizszintes = 3;
int fuggoleges = 3;

int osszeg = 0;
int osztando = 0;

Console.WriteLine("Adatok kiírása:");
for (int i = 1; i <= vizszintes; i++)
{
    for (int j = 1; j <= fuggoleges; j++)
    {
        if (j % 3 == 0)
        {
            Console.WriteLine(array[i - 1, j - 1] + " ");
        }
        else
        {
            Console.Write(array[i - 1, j - 1] + " ");
        }
    }
}

Console.WriteLine();


Console.WriteLine("Globális átlag");
for (int i = 2; i <= vizszintes; i++)
{
    for (int j = 2; j <= fuggoleges; j++)
    {
        osszeg = osszeg + Convert.ToInt32(array[i - 1, j - 1]);
        osztando++;
    }
}
Console.WriteLine("Összeg: " + osszeg);
Console.WriteLine("Osztandó: " + osztando);
Console.WriteLine("Átlag: " + Convert.ToDecimal(osszeg) / Convert.ToDecimal(osztando));

Console.WriteLine();

Console.WriteLine("Tanulónkénti átlag");
osszeg = 0;
osztando = 0;

for (int i = 1; i <= vizszintes; i++)
{
    for (int j = 1; j <= fuggoleges; j++)
    {
        if (j % 3 == 0)
        {
            if ((i != 1) && (j != 1))
            {
                osszeg = osszeg + Convert.ToInt32(array[i - 1, j - 1]);
                osztando++;
                Console.WriteLine(array[i - 1, 0] + " átlaga = " + Convert.ToDecimal(osszeg) / Convert.ToDecimal(osztando));
            }
            osszeg = 0;
            osztando = 0;
        }
        else if ((i != 1) && (j != 1))
        {
            osszeg = osszeg + Convert.ToInt32(array[i - 1, j - 1]);
            osztando++;
        }
    }
}

Console.ReadKey();