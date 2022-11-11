// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

// Alkohol kérdés
Console.WriteLine("Eldönti hogy mit ihat");
Console.WriteLine("Hánny éves vagy? ");
int kor = int.Parse(Console.ReadLine());

if(kor >= 18) Console.WriteLine("Mit kérsz? ");
else{
    if (kor < 16) Console.WriteLine("Kakaó vagy tej?");
    else{
        Console.WriteLine("Hol vagy (A/H): ");
        string hely = Console.ReadLine();
        if (hely == "A" || hely == "a") Console.WriteLine("Milyen sört kérsz?");
        else Console.WriteLine("Kakaó vagy tej?");
    }
}

Console.ReadKey();