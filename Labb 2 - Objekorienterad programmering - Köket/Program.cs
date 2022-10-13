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
        Console.WriteLine("Tryck valfri tangent för att återgå till meny");
        Console.ReadLine();
        Console.Clear();
        meny.Huvudmeny();
    }
    else if (userInputMainMenu == 3) //Lista köksapparater
    {
        Console.Clear();
        meny.Lista();
        Console.ReadLine();
    }
    else if (userInputMainMenu == 4) //Ta bort köksapparat
    {
        Console.Clear();
    }
    else if (userInputMainMenu == 5) //Avsluta
    {
        Console.Clear();
        Console.WriteLine("Programmet har avslutats\n" + 
            "Du kan ny stänga fönstret.");
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

