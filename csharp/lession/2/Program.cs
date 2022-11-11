// Strandbelépő
/*
Console.WriteLine("Kiszámítom a strandbelépőt!");

Console.BackgroundColor = ConsoleColor.Blue;
Console.Write("Hány éves vagy? ");
Console.ResetColor();
int kor = int.Parse(Console.ReadLine());

Console.Write("A fizetendő összeg:\t");
Console.ForegroundColor = ConsoleColor.Green;

if (kor < 18) Console.WriteLine("1000 Ft");
else if (kor < 65) Console.WriteLine("5000 Ft");
else if (kor < 110) Console.WriteLine("1500 Ft");
else Console.WriteLine("Nem kell fizetni.");
*/

// Évszakok
/*
Console.WriteLine("Hónap alapján évszak\n");
Console.Write("Melyik hónapban szüledtél? ");
int honap = int.Parse(Console.ReadLine());

switch (honap)
{
    case 1:
    case 2:
    case 12:
        Console.WriteLine("Tél");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Tavasz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Nyár");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Ősz");
        break;
    default:
        Console.WriteLine("Nincs ilyen hónap!");
        break;
}
*/

// Számlál
/*Console.WriteLine("Meddig számoljak? ");
int maxSzam = int.Parse(Console.ReadLine());
while (maxSzam >= Console.WindowWidth-1)
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Túl nagy az érték.");
    Console.ResetColor();
    Console.WriteLine("Meddig számoljak? ");
    maxSzam = int.Parse(Console.ReadLine());
}

Console.Clear();
Console.CursorVisible = false;
for (int i = 1; i <= maxSzam; i++)
{
    Console.SetCursorPosition(i, 10+i);
    Console.WriteLine(i);
}
*/

// Számkitaláló
/*
Console.WriteLine("Gondoltam egy számra (1-100) találd ki!");
Random r = new Random();
int kitalalandoSzam = r.Next(1, 101);
int tipp;
int tippSzamlalo = 0;

do
{
    Console.WriteLine("Add meg a tipped: ");
    tipp = int.Parse(Console.ReadLine());
    tippSzamlalo++;
    if (tipp > kitalalandoSzam) Console.WriteLine("Túl nagy!");
    else if (tipp < kitalalandoSzam) Console.WriteLine("Túl kicsi!");
} while (tipp != kitalalandoSzam && tippSzamlalo < 5);

if (tippSzamlalo > 5 || tipp != kitalalandoSzam) Console.WriteLine("Nem sikerült kitalálnni!");
else Console.WriteLine(tippSzamlalo + ". próbálkozásra sikerült kitalálni!");
*/

// Zenei equalizer
Console.CursorVisible = false;
int maxX = Console.WindowWidth;
int maxY = Console.WindowHeight;

Random random = new Random();

for(int i=0; i < 50; i++){
    int x = random.Next(0, maxX);
    int yMag = random.Next(0, maxY);
    Console.Beep(100*x+1, 100);
    for(int y = maxY; y > 25; y--){
        Console.SetCursorPosition(x, y);
        Console.Write("*");
        System.Threading.Thread.Sleep(5);
    }
}


Console.ReadKey();