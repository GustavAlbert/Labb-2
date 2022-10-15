using Class.Inventory;
using Interface;
using Labb_2___Objekorienterad_programmering___Köket;
using System.Threading.Channels;
using Variables;

//Creating "meny."
var meny = new Meny();

//Creating "ApplianceInventory."
var kitchen = new Kitchen();

//Run Software
bool Run = true;



while (Run = true)
{
    meny.Huvudmeny();
    int userInputMainMenu = Convert.ToInt32(Console.ReadLine());

    if (userInputMainMenu == 1) //Använd köksapparat
    {
        Console.Clear();
        meny.Använd();
    }
    else if (userInputMainMenu == 2) //Lägg till köksapparat
    {
        Console.Clear();
        meny.LäggTill();
        Console.WriteLine("Tryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
        Console.Clear();
    }
    else if (userInputMainMenu == 3) //Lista köksapparater
    {
        Console.Clear();
        meny.Lista();
        Console.WriteLine("\n \n Tryck Enter för att återgå till huvudmenyn");
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
            "Du kan nu stänga fönstret.");
        Run = false;
        return;
    }
    else
    {
        Console.Clear();
        Console.WriteLine
            ("Du har angett ett ogiltigt val\n" +
            "Vänligen försök igen.");
        meny.Huvudmeny();
        return;
    }
}

