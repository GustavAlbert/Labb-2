using Class.Inventory;
using Interface;
using Labb_2___Objekorienterad_programmering___Köket;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using MyMethods;

// !!! VARIABEL - SMÅ BOKSTÄVER !!!
// !!! VARIABLER - Ljus blåa !!!

//Creating "meny."
var meny = new Meny();

//Run Software
bool run = true;

//
meny.kitchen.Inventories.Add(new Inventory("Ugn", "Electrolux", true));
meny.kitchen.Inventories.Add(new Inventory("Kyl", "SMEG", true));
meny.kitchen.Inventories.Add(new Inventory("Frys", "SMEG", true));
meny.kitchen.Inventories.Add(new Inventory("Spis", "Siemens", true));


meny.Huvudmeny();
while (run == true)
try
{
    int userInputMainMenu = Convert.ToInt32(Console.ReadLine());

    if (userInputMainMenu == 1) //Använd köksapparat
    {
        Console.Clear();
        meny.Använd();
        //Console.Clear();
    }
    else if (userInputMainMenu == 2) //Lägg till köksapparat
    {
        Console.Clear();
        meny.LäggTill();
        //Console.WriteLine("Tryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
        Console.Clear();
    }
    else if (userInputMainMenu == 3) //Lista köksapparater
    {
        Console.Clear();
        meny.Lista();
        //Console.WriteLine("\n \n Tryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
        Console.Clear();
    }
    else if (userInputMainMenu == 4) //Ta bort köksapparat
    {
        Console.Clear();
        meny.TaBort();
    }
    else if (userInputMainMenu == 5) //Avsluta
    {
        Console.Clear();
        Console.WriteLine("Programmet har avslutats\n" +
            "Du kan nu stänga fönstret eller klicka Enter tangenten.");
        run = false;
    }
}
catch
{
    Console.WriteLine
        ("Du har angett ett ogiltigt val\n" +
        "Enter tangent för att omdirigeras till huvudmeny.");
    Console.ReadLine();
    Console.Clear();
    meny.Huvudmeny();
}

/*
while (run == true)
{
    int userInputMainMenu = Convert.ToInt32(Console.ReadLine());

    if (userInputMainMenu == 1) //Använd köksapparat
    {
        Console.Clear();
        meny.Använd();
        //Console.Clear();
    }
    else if (userInputMainMenu == 2) //Lägg till köksapparat
    {
        Console.Clear();
        meny.LäggTill();
        //Console.WriteLine("Tryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
        Console.Clear();
    }
    else if (userInputMainMenu == 3) //Lista köksapparater
    {
        Console.Clear();
        meny.Lista();
        //Console.WriteLine("\n \n Tryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
        Console.Clear();
    }
    else if (userInputMainMenu == 4) //Ta bort köksapparat
    {
        Console.Clear();
        meny.TaBort();
    }
    else if (userInputMainMenu == 5) //Avsluta
    {
        Console.Clear();
        Console.WriteLine("Programmet har avslutats\n" +
            "Du kan nu stänga fönstret eller klicka Enter tangenten.");
        run = false;
    }
}
*/
