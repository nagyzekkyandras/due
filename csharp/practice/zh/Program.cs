Console.WriteLine("ZH feladat 1.");

Console.WriteLine("add meg a számot");
int x = int.Parse(Console.ReadLine());

int e = 1;

for (int i = 1; i <= x; i++)
{
    e = (10 + i) * e;
}

Console.WriteLine("Az eredmény: " + e);


Console.WriteLine("ZH feladat 2.");

int[] vektor = { 21, 453, 88, 64, 98, 203 };

int vane = 0;

for (int i = 0; i < vektor.Length; i++)
{
    if (vektor[i]%2 == 0)
    {
        if (vektor[i] > vektor[i + 1])
        {
            vane=vane+1;
        }
    }
}

Console.WriteLine("Van-e olyan elem ami páros és az utána lévő elemnél is nagyobb: " + vane);


Console.WriteLine("ZH feladat 3.");

int[] szamok = new int[10];
int db = 1;

Console.Write("Adjon meg 10 db számot!");

for (int i = 0; i < szamok.Length; i++)
{
    Console.Write("\nKérem adja meg a " + db + "-edik számot: ");
    szamok[i] = int.Parse(Console.ReadLine());
    db++;
}
for (int i = 0; i < szamok.Length; i++)
{
    Console.Write("\nA megadott számok: " + szamok[i] + " ");
}
int minimum = szamok[0];
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] >= 0)
    {
        if (szamok[i] < minimum)
        {
            minimum = szamok[i];
        }
    }
}
Console.Write("\nA legkisebb szám: " + minimum);

Console.ReadKey();