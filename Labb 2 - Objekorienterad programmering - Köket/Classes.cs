using Class.Inventory;
using Interface;
using Labb_2___Objekorienterad_programmering___Köket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.Write(Brand + " " + Type);
            if (IsFunctioning)
            {
                Console.WriteLine(" används nu.");
            }
            else
            {
                Console.WriteLine(" är ur funktion och kan därför inte användas.");
            }
        }
    }
}

namespace MyMethods
{
    public class Meny
    {
        public Kitchen kitchen = new Kitchen();

        public void Huvudmeny()
        {
            Console.WriteLine
            ("======= Köket =======\n" +
            "1. Använd köksapparat\n" +
            "2. Lägg till Köksapparat\n" +
            "3. Lista köksapparat\n" +
            "4. Ta bort köksapparat\n" +
            "5. Avsluta\n" +
            "--------------------\n" +
            "Ange val:");
        }

        public void Använd()
        {
            Console.WriteLine("Ange numret för den produkt du vill använda\n" + "--------------------");
            NumreradLista();
            Console.WriteLine("-------------------");
            int usingproduct = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            kitchen.Inventories[usingproduct - 1].Use();
            ReturnToMainMenu();
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
                Console.WriteLine
                    ("Du har angivit ett blankt svar, köksutrustningen kan inte läggas in med ett blankt svar i detta fält.");
                LäggTill();
            }
            Console.Write("Ange tillverkare: ");
            var brand = Console.ReadLine();
            if (brand == string.Empty)
            {
                IsVerifiedToAdd = false;
                Console.WriteLine
                    ("Du har angivit ett blankt svar, köksutrustningen kan inte läggas in med ett blankt svar i detta fält.");
                LäggTill();
            }
            Console.Write("Är produkten fungerande? j/n: ");
            var qfunctional = Console.ReadLine(); //Svar på frågeställningen om utrustningen är i funktionellt bruk. 
            bool functional = false;
            if ((qfunctional == "j") || (qfunctional == "J"))
            {
                functional = true;
            }
            else if ((qfunctional == "n") || (qfunctional == "N"))
            {
                functional = false;
            }
            else
            {
                Console.WriteLine("Du har angivit ett ogitligt val, vänligen försök igen.");
                IsVerifiedToAdd = false;
            }
            if (IsVerifiedToAdd == true)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(brand + " " + type + " har lagts in i systemet och finns nu tillgänglig i utrustningslistan");
                kitchen.LäggTill(new Inventory(type, brand, functional));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Förutsättningarna för att lägga till en ny köksprodukt har inte uppfyllts, vänligen försök igen\n" +
                                  " 1) Försök igen\n 2) Huvudmeny\n" + "----------");
                int adderrormessagechoice = Convert.ToInt32(Console.ReadLine());
                if (adderrormessagechoice == 1)
                {
                    LäggTill();
                }
                else if (adderrormessagechoice == 2)
                {
                    ReturnToMainMenu();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, försök igen");
                    return;
                }
            }
        }

        public void Lista()
        {
            foreach (var inventory in kitchen.Inventories)
            {
                Console.WriteLine(inventory.ListSpecifications());
            }
            Console.WriteLine("--------------------\n");
            ReturnToMainMenu();
        }


        public void TaBort()
        {
            NumreradLista();
            Console.WriteLine("--------------------");
            Console.WriteLine("Mata in numret på den köksprodukt du vill ta bort från listan.");
            int itemid = Convert.ToInt32(Console.ReadLine());
            //Item ID är siffran i listan som är kopplad till den specifika utrustningen användaren vill ta bort. 
            kitchen.Inventories.RemoveAt(itemid - 1);
            //Console.WriteLine("Köksutrustning " + itemid + " har tagits bort från listan.");
            Console.Clear();
            NumreradLista();
            Console.WriteLine("--------------------");
            Console.WriteLine("Köksutrustningen har tagits bort från listan.");
            ReturnToMainMenu();
        }
        
        public void NumreradLista() //Gör listan av inventarier numrerad. 
        {
            int ListItemID = 1;
            foreach (var inventory in kitchen.Inventories)
            {
                Console.Write(ListItemID + " ");
                Console.WriteLine(inventory.ListSpecifications());
                ListItemID++;
            }
        }

        public void ReturnToMainMenu() //Återgå till hvuudmeny. 
        {
            Console.WriteLine("Tryck Enter för att återgå till huvudmenyn");
            //Console.ReadLine();
        }
        
        //public void H()

        //public void I()
    }
}







