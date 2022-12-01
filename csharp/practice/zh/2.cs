using System;

string[,] array = new string[3, 3] {
                                  { "N�v", "Matek", "Fizika" },
                                  { "Pista", "1", "4" },
                                  { "B�la", "3", "3" }
                                };

int vizszintes = 3;
int fuggoleges = 3;

int osszeg = 0;
int osztando = 0;

Console.WriteLine("Adatok ki�r�sa:");
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


Console.WriteLine("Glob�lis �tlag");
for (int i = 2; i <= vizszintes; i++)
{
    for (int j = 2; j <= fuggoleges; j++)
    {
        osszeg = osszeg + Convert.ToInt32(array[i - 1, j - 1]);
        osztando++;
    }
}
Console.WriteLine("�sszeg: " + osszeg);
Console.WriteLine("Osztand�: " + osztando);
Console.WriteLine("�tlag: " + Convert.ToDecimal(osszeg) / Convert.ToDecimal(osztando));

Console.WriteLine();

Console.WriteLine("Tanul�nk�nti �tlag");
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
                Console.WriteLine(array[i - 1, 0] + " �tlaga = " + Convert.ToDecimal(osszeg) / Convert.ToDecimal(osztando));
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