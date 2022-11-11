class Program
{
    static void MyMethod()
    {
      Console.WriteLine("Lefutottam!");
    }

    static void MyName(string fname) 
    {
      Console.WriteLine("A nevem: " + fname);
    }

    static int MyAgeInDays(int x) 
    {
      return x * 365;
    }

    static void Main(string[] args)
    {
      MyMethod();
      MyName("Andras");
      Console.WriteLine("Ennyi napos vagyok: " + MyAgeInDays(27));
    }
}