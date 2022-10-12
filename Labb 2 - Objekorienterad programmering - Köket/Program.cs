using Class.Inventory;
using Interface;
using Labb_2___Objekorienterad_programmering___Köket;
using Variables;

var meny = new Meny();
bool Run = true;
var globalApplianceInventory = new List<ApplianceInventory>()
                             { new ApplianceInventory("Mixer") };

//List<Kitchenappliances> Köksapparat = new List<Kitchenappliances>(); //Skapar en instans av en lista innehållande typ Kitchenappliance


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
        Console.WriteLine("Programmet har avslutats");
        Run = false;
    }
    else
    {
        Console.Clear();
        Console.WriteLine
            ("Du har angett ett ogiltigt val\n" +
            "Vänligen försök igen.");
    }
}
