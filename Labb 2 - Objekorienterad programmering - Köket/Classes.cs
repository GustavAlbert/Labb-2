using Class.Inventory;
using Labb_2___Objekorienterad_programmering___Köket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IKitchenAppliance
    {
        string Type { get; set; }
        string Brand { get; set; }
        bool IsFunctioning { get; set; }
        int ID { get; set; }
        void Use();
    }
}

namespace Class.Inventory
{
    public class ApplianceInventory
    {
        public string Appliance { get; set; }
        public List<ApplianceInventory> localApplianceInventory { get; set; }

        public ApplianceInventory(string type)
        {
            Appliance = type;
        }
    }
}

namespace Variables
{
    public class Meny
    {
        //List<Kitchenappliances> Köksapparater = new List<Kitchenappliances>(); //Skapar en instans av en lista innehållande typ Kitchenappliance
        public void Huvudmeny()
        {
            Console.WriteLine
            ("===== Köket =====\n" +
            "1. Använd köksapparat\n" +
            "2. Lägg till Köksapparat\n" +
            "3. Lista köksapparat\n" +
            "4. Ta bort köksapparat\n" +
            "5. Avsluta\n" +
            "Ange val:");
        }

         /*public void Använd()
         {
            for (int i = 1; i < 5; i++)
            {
                Kitchenappliance kitchenappliance = new Kitchenappliance();
                switch (i)
                {
                    case 1:
                        kitchenappliance.Type = "Mikro";
                        kitchenappliance.Brand = "Electrolux";
                        kitchenappliance.IsFunctioning = true;
                        kitchenappliance.ID = i;
                        break;
                    case 2:
                        kitchenappliance.Type = "Brödrost";
                        kitchenappliance.Brand = "Electrolux";
                        kitchenappliance.IsFunctioning = true;
                        kitchenappliance.ID = i;
                        break;
                    case 3:
                        kitchenappliance.Type = "Ugn";
                        kitchenappliance.Brand = "Electrolux";
                        kitchenappliance.IsFunctioning = true;
                        kitchenappliance.ID = i;
                        break;
                    case 4:
                        kitchenappliance.Type = "Mixer";
                        kitchenappliance.Brand = "Samsung";
                        kitchenappliance.IsFunctioning = false;
                        kitchenappliance.ID = i;
                        break;
                }
                Köksapparater.Add(kitchenappliance);
            }

            Console.WriteLine
            ("=== Välj Köksapparat ===");

            foreach (Kitchenappliance appliance in Köksapparater)
            {
                Console.WriteLine($"{appliance.ID}. {appliance.Type}. ");
            }

            var selectedAppliance = Console.ReadLine();
            foreach (Kitchenappliance appliance in Köksapparater)
            {
                //Console.WriteLine($"{appliance.ID}. {appliance.Type}. ");
                if (appliance.ID.ToString() == selectedAppliance)
                {
                    if (appliance.IsFunctioning)
                    {
                        Console.WriteLine("Köksapparaten används nu");
                    }
                    else
                    {
                        Console.WriteLine("Apparaten är ur funktion och " +
                                          "kan inte användas för tillfället");
                    }
                }
            }
        }
        */
       
        public void Använd()
        {

        }

        public void LäggTill()
        {

        }

        public void Lista()
        {
            
        }

        public void TaBort()
        {

        }

        //public void E()

        //public void F()

        //public void G()
    }
}







