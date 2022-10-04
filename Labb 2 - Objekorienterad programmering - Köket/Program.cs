//Meny 
static void HuvudMeny()
{
    Console.WriteLine
        ("===== Köket =====\n" +
        "1. Använd köksapparat\n" +
        "2. Lägg till Köksapparat\n" +
        "3. Liusta köksapparat\n" +
        "4. Ta bort köksapparat\n" +
        "5. Avsluta\n" +
        "Ange val:");
}

static void underMeny()
{
    Console.WriteLine
    ();
}

bool Launch = true;

while (Launch = true)
{
    HuvudMeny();
    int userinputmainmenu = Convert.ToInt32(Console.ReadLine());
    
    if (userinputmainmenu == 1) 
    {
        Console.Clear();

        break;
    }
    else if (userinputmainmenu == 2)
    {
        Console.Clear();
        break;
    }
    else if (userinputmainmenu == 3)
    {
        Console.Clear();
        break;
    }
    else if (userinputmainmenu == 4)
    {
        Console.Clear();
        break;
    }
    else if (userinputmainmenu == 5)
    {
        Console.Clear();
        Console.WriteLine("Programmet avlsutades successfully");
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

