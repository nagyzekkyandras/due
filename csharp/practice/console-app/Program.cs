//using System;
//namespace heron
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a, b, c;
//            double s, T;
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            Console.WriteLine("Adja meg a háromszög három oldalának hosszát");
//            Console.Write("a="); a = int.Parse(Console.ReadLine());
//            Console.Write("b="); b = Convert.ToInt32(Console.ReadLine());
//            Console.Write("c="); c = int.Parse(Console.ReadLine());
//            if (a + b > c && a + c > b && b + c > a)
//            {
//                s = (a + b + c) / 2; // Ezzel baj lehet a típus konverzió miatt.
//                s = ((double)a + b + c) / 2; // Így már biztos jó.
//                s = (Convert.ToDouble(a) + b + c) / 2; // De Így is jó lehet.
//                T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
//                Console.WriteLine("A háromszög területe T=" + T);
//            }
//            else
//            {
//                Console.WriteLine("A megadott számok nem alkothatnak háromszöget a=" + a + ", b=" + b + ", c=" + c);
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//namespace sorosszeg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, n;
//            long s;
//            double r_s;
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            Console.WriteLine("Adja meg, hogy meddig akarja a számokat összegezni");
//            Console.Write("n="); n = int.Parse(Console.ReadLine());
//            for (i = 1, s = 0, r_s = 0; i <= n; i++) // három paraméteres for ( ; ; )
//            {
//                s = s + i; // for (ciklus változó inicializálása; logikai állítása ; ciklus változó módosítása )
//                r_s = r_s + 1.0 / i;
//                Console.WriteLine("i= " + i + ", s=" + s + ", reciprok összeg=" + r_s);
//            }
//        }
//    }
//}


//using System;
//namespace tomb_elem_osszeg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, n;
//            long s;
//            int[] tomb = new int[10];
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            do
//            {
//                Console.WriteLine("Adja meg hány darab számot szeretne beolvasni maximum 10 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//                Console.Clear();
//            } while (n < 1 || n > 10);
//            for (i = 0, s = 0; i < n; i++)
//            {
//                Console.Write("tomb[" + i + "]="); tomb[i] = int.Parse(Console.ReadLine());
//                s = s + tomb[i]; // A tömb index mindíg nulláról indul!!!!
//            }
//            Console.WriteLine(" A tömb elemeinek összege s=" + s); Console.ReadKey();
//        }
//    }
//}

//using System;
//namespace tomb_elemek_rendezese
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, j, n, temp;
//            int[] tomb = new int[20];
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            do
//            {
//                Console.WriteLine("Adja meg hány darab számot szeretne beolvasni maximum 20 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//                Console.Clear();
//            } while (n < 1 || n > 20);
//            Console.WriteLine("\n\n Gépelje be a számokat \n\n");
//            for (i = 0; i < n; i++)
//            {
//                Console.Write("tomb[" + i + "]="); tomb[i] = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("\n\n A begépelt számok a rendezés előtt \n\n"); Console.ReadKey();
//            for (i = 0; i < n; i++)
//            {
//                Console.WriteLine("tomb[" + i + "]=" + tomb[i]);
//            }
//            Console.WriteLine("\n\n A begépelt számok rendezve \n\n"); Console.ReadKey();
//            for (i = 0; i < n - 1; i++)
//            {
//                for (j = i + 1; j < n; j++)
//                {
//                    if (tomb[i] > tomb[j])
//                    {
//                        temp = tomb[i]; tomb[i] = tomb[j]; tomb[j] = temp; // Ez itt a csere!
//                    }
//                }
//            }
//            for (i = 0; i < n; i++)
//            {
//                Console.WriteLine("tomb[" + i + "]=" + tomb[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//namespace matrix_transzp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, j, n, m;
//            int[,] matr = new int[10, 10]; int[,] matr_tr = new int[10, 10];
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            do
//            {
//                Console.WriteLine("Adja meg hány sora legyen a mátrixnak, maximum 10 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//                Console.WriteLine("Adja meg hány oszlopa legyen a mátrixnak, maximum 10 db lehet");
//                Console.Write("m="); m = int.Parse(Console.ReadLine());
//                Console.Clear();
//            } while (n < 1 || n > 10 || m < 1 || m > 10);
//            for (i = 0, Console.WriteLine("mátrix elemeinek beolvasása"); i < n; i++)
//            {
//                for (j = 0; j < m; j++)
//                {
//                    Console.Write("mátrix[" + i + ", " + j + "]="); matr[i, j] = int.Parse(Console.ReadLine());
//                }
//            }
//            Console.WriteLine(" A begépelt mátrix elemei egy billentyű lenyomása után következik:\n");
//            Console.ReadKey();
//            for (i = 0; i < n; i++)
//            {
//                for (j = 0; j < m; j++)
//                {
//                    Console.Write(matr[i, j] + " ");
//                }
//                Console.WriteLine("");
//            }
//            Console.WriteLine("\n\n A mátrix transzponáltja egy újabb billentyű lenyomása után következik:\n");
//            Console.ReadKey();
//            for (i = 0; i < n; i++)
//            {
//                for (j = 0; j < m; j++)
//                {
//                    matr_tr[j, i] = matr[i, j];
//                }
//            }
//            for (i = 0; i < m; i++)
//            {
//                for (j = 0; j < n; j++)
//                {
//                    Console.Write(matr_tr[i, j] + " ");
//                }
//                Console.WriteLine("");
//            }
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//namespace MatekFunctions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double x, y, z;
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            z = -Math.Floor(6.19);
//            Console.WriteLine("z=" + z);
//            x = Math.Abs(z);
//            Console.WriteLine("x=" + x);
//            x = Math.Pow(2, x);
//            Console.WriteLine("x=" + x);
//            y = Math.Sqrt(x);
//            Console.WriteLine("y=" + y);
//            x = Math.PI / 6;
//            y = Math.Sin(x);
//            Console.WriteLine("x=" + x + ", y=" + y);
//            x = Math.E * Math.E;
//            y = Math.Log(x);
//            Console.WriteLine("x=" + x + ", y=" + y);
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//namespace listak_kezelese
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            List<double> lista = new List<double>(10);
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            Console.WriteLine("A lista kapacitása: " + lista.Capacity + ", a mérete pedig: " + lista.Count);
//            Console.WriteLine("Nyomja meg az Entert, aminek hatására a program három új elemet ad a listához \n\n ");
//            Console.ReadKey();
//            lista.Add(-3.2); lista.Add(5); lista.Add(2);
//            Console.WriteLine("A lista kapacitása: " + lista.Capacity + ", a mérete pedig: " + lista.Count);
//            for (i = 0; i < lista.Count; i++)
//            {
//                Console.WriteLine("lista elemei[ " + i + "]= " + lista[i]);
//            }
//            Console.WriteLine("\nNyomja meg az Entert, aminek hatására a program egy új elemet szúr be a második helyre \n\n ");
//            lista.Insert(1, 12);
//            for (Console.ReadKey(), i = 0; i < lista.Count; i++)
//            {
//                Console.WriteLine("lista elemei[ " + i + "]= " + lista[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}



//using System;
//namespace Pi_kiszamitasa
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, n, m;
//            double xp, yp, pi_erteke;
//            Random rnd = new Random();
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Clear();
//            do
//            {
//                Console.WriteLine("Ez a program kiszámítja a pi közelítő értékét MonteCarlo módszerrel");
//                Console.WriteLine("Adja meg hány darab pontot generáljunk maximum 100 000 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//                Console.Clear();
//            } while (n < 1 || n > 100000);
//            for (i = 0, m = 0; i <= n; i++)
//            {
//                xp = rnd.NextDouble(); yp = rnd.NextDouble();
//                if (Math.Sqrt(xp * xp + yp * yp) <= 1)
//                {
//                    m++;
//                }
//            }
//            pi_erteke = 4.0 * m / n;
//            Console.WriteLine(" A pi közelítő értéke: " + pi_erteke);
//            Console.ReadKey();
//        }
//    }
//}



//using System;
//namespace Integral_MC_modszerrel
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, n;
//            double x, f_x, a, b, s;
//            Random rnd = new Random();
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Ez a program kiszámítja az x*x függvény határozott integrálját");
//                Console.WriteLine(" a megadott [a,b] intervallumon MonteCarlo módszerrel");
//                Console.WriteLine("Adja meg hány darab pontot generáljunk maximum 100 000 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//            } while (n < 1 || n > 100000);
//            Console.WriteLine("Adja meg az intervallum határait");
//            Console.Write("a="); a = double.Parse(Console.ReadLine());
//            Console.Write("b="); b = double.Parse(Console.ReadLine());
//            for (i = 0, s = 0; i <= n; i++)
//            {
//                x = a + (b - a) * rnd.NextDouble(); f_x = x * x;
//                s += f_x;
//            }
//            s = s * (b - a) / n;
//            Console.WriteLine(" Az integrál közelítő értéke: " + s);
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//namespace Integral_MC_modszerrel
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, n;
//            double x, f_x, a, b, s;
//            Random rnd = new Random();
//            Console.BackgroundColor = ConsoleColor.DarkBlue;
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Ez a program kiszámítja az sin(x) függvény határozott integrálját");
//                Console.WriteLine(" a megadott [a,b] intervallumon MonteCarlo módszerrel");
//                Console.WriteLine("Adja meg hány darab pontot generáljunk maximum 100 000 db lehet");
//                Console.Write("n="); n = int.Parse(Console.ReadLine());
//            } while (n < 1 || n > 100000);
//            Console.WriteLine("Adja meg az intervallum határait");
//            Console.Write("a="); a = double.Parse(Console.ReadLine());
//            Console.Write("b="); b = double.Parse(Console.ReadLine());
//            for (i = 0, s = 0; i <= n; i++)
//            {
//                x = a + (b - a) * rnd.NextDouble(); f_x = Math.Sin(x);
//                s += f_x;
//            }
//            s = s * (b - a) / n;
//            Console.WriteLine(" Az integrál közelítő értéke: " + s);
//            Console.ReadKey();
//        }
//    }
//}



//using System;
//namespace StringKezeles
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i, db;
//            int[] poziciok = new int[100];
//            string szoveg, str_be;
//            char ch;
//            Console.BackgroundColor = ConsoleColor.White;
//            Console.ForegroundColor = ConsoleColor.DarkBlue;
//            Console.Clear();
//            Console.WriteLine("Írjon be egy tetszőleges szöveget: ");
//            Console.Write("szoveg="); szoveg = Console.ReadLine();
//            Console.WriteLine("Adjon meg egy betűt");
//            Console.Write("betű="); str_be = Console.ReadLine();
//            for (i = 0, db = 0, ch = str_be[0]; i < szoveg.Length; i++)
//            {
//                if (szoveg[i] == ch)
//                {
//                    poziciok[db] = i;
//                    db++;
//                }
//            }
//            Console.WriteLine("megadott betű ennyiszer szerepel a szövegben: " + db);
//            Console.WriteLine("ezeken a helyeken: ");
//            for (i = 0; i < db; i++)
//            {
//                Console.WriteLine(poziciok[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}


//using System;
//namespace strukturalprg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] tomb = new int[100];
//            int n, max_e, helye = 0;
//            n = tomb_olvas(tomb);
//            tomb_kiir(tomb, n);
//            max_e = max_keres(tomb, n, ref helye);
//            Console.WriteLine("max elem: " + max_e + ", és pozíciója: " + helye);
//            Console.ReadKey();
//            tomb_rnd_gen(tomb, n);
//            tomb_kiir(tomb, n);
//            max_e = max_keres(tomb, n, ref helye);
//            Console.WriteLine("max elem: " + max_e + ", és pozíciója: " + helye);
//            Console.ReadKey();
//        }
//        static int tomb_olvas(int[] t)
//        {
//            int db, i;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Adja meg hány darab számot szeretne beolvasni, max 100 darab:");
//                Console.Write("db="); db = int.Parse(Console.ReadLine());
//            } while (db < 0 || db > 100);
//            for (Console.Clear(), i = 0; i < db; i++)
//            {
//                Console.Write("t[" + i + "]="); t[i] = int.Parse(Console.ReadLine());
//            }
//            return db;
//        }
//        static void tomb_kiir(int[] t, int n)
//        {
//            int i;
//            for (Console.Clear(), i = 0; i < n; i++)
//            {
//                Console.WriteLine("tomb[" + i + "]=" + t[i]);
//            }
//        }
//        static int max_keres(int[] t, int n, ref int pozicio)
//        {
//            int i, max_val;
//            for (max_val = t[0], i = 1; i < n; i++)
//            {
//                if (max_val <= t[i])
//                {
//                    max_val = t[i]; pozicio = i;
//                }
//            }
//            return max_val;
//        }
//        static void tomb_rnd_gen(int[] t, int n)
//        {
//            Random r = new Random(); int i;
//            for (i = 0; i < n; i++)
//            {
//                t[i] = r.Next(1, 51);
//            }
//        }
//    }
//}

using System;
using System.IO;
namespace file_iro
{
    class Program
    {
        static void Main()
        {
            int i, n;
            StreamWriter f = new StreamWriter("data.txt");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                f.WriteLine("i=" + i);
            }
            f.Flush(); f.Close();
        }
    }
}
