using Variables;

var meny = new Meny();


bool Launch = true;

while (Launch = true)
{
    meny.Huvudmeny();
    int userInputMainMenu = Convert.ToInt32(Console.ReadLine());
    
    if (userInputMainMenu == 1) 
    {
        Console.Clear();

        break;
    }
    else if (userInputMainMenu == 2)
    {
        Console.Clear();
        break;
    }
    else if (userInputMainMenu == 3)
    {
        Console.Clear();
        break;
    }
    else if (userInputMainMenu == 4)
    {
        Console.Clear();
        break;
    }
    else if (userInputMainMenu == 5)
    {
        Console.Clear();
        Console.WriteLine("Programmet avslutades successfully");
        Launch = false;
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine
            ("Du har angett ett ogiltigt val\n" +
            "Vänligen försök igen.");
    }
}
