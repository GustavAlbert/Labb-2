using Class.Inventory;
using Interface;
using Labb_2___Objekorienterad_programmering___Köket;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    //public class ApplianceInventory
    //{
    //    public string Appliance { get; set; }
    //    public List<ApplianceInventory> localApplianceInventory { get; set; }

    //    public ApplianceInventory(string type)
    //    {
    //        Appliance = type;
    //    }
    //}

    public class Kitchen
    {
        public List<Inventory> Inventories { get; set; } = new List<Inventory>();

        public void LäggTill(Inventory inventory)
        {
            Inventories.Add(inventory);
        }
    }
    public class Inventory
    {
        public string Type { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public bool IsFunctioning { get; set; }

        public Inventory(string type, string brand, bool functional)
        {
            Type = type;
            Brand = brand;
            IsFunctioning = functional;
        }
        public string ListSpecifications()
        {
            string output = Type + " " + Brand + " ";
            if (IsFunctioning == true)
            {
                output += "fungerar";
            }
            else if (IsFunctioning == false)
            {
                output += "är ur funktion";
            }
            return output;
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Variables
{
    public class Meny
    {
        Kitchen kitchen = new Kitchen(); 
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
            bool IsVerifiedToAdd = true;
            Console.WriteLine("=== Lägg till ny köksutrustning ===\n");
            Console.Write("Ange utrustningstyp: ");
            var type = Console.ReadLine();
            if (type == string.Empty)
            {
                IsVerifiedToAdd = false;
                Console.WriteLine("Du har angivit ett blankt svar, köksutrustningen har inte lagts in.");
            }
            Console.Write("Ange tillverkare: ");
            var brand = Console.ReadLine();
            if (brand == string.Empty)
            {
                IsVerifiedToAdd = false;
                Console.WriteLine("Du har angivit ett blankt svar, köksutrustningen har inte lagts in.");
            }
            Console.Write("Är produkten fungerande? j/n: ");
            var qfunctional = Console.ReadLine();
            bool functional = false;
            if ((qfunctional == "j") || (qfunctional == "J"))
            {
                functional = true;
            }
            else if ((qfunctional == "n") || (qfunctional == "N"))
            {
                functional= false;
            }
            else
            {
                Console.WriteLine("Du har angivit ett ogitligt val, vänligen försök igen.");
                IsVerifiedToAdd=false;
            }
            if (IsVerifiedToAdd == true)
            {
                Console.WriteLine
                    ("--------------------" + "\n" + type + " har lagts in i systemet successfully!");
                kitchen.LäggTill(new Inventory(type, brand, functional));
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Förutsättningarna för att lägga till en ny köksprodukt har inte uppfyllts, vänligen försök igen");
                LäggTill();
            }
        }

        public void Lista()
        {
            foreach (var inventory in kitchen.Inventories)
            {
                Console.WriteLine(inventory.ListSpecifications());
            }
        }

        public void TaBort()
        {

        }

        //public void E()

        //public void F()

        //public void G()
    }
}







