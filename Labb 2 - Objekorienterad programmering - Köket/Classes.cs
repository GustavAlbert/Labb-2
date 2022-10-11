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
        void Use();
    }
}

namespace Classes
{

}

namespace Variables
{
    public class Meny
    {
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

        public void Använd()
        {
            List<string> Köksapparat = new List<string>();

            Köksapparat.Add("Mikro");
            Köksapparat.Add("Brödrost");
            Köksapparat.Add("Ugn");
            Köksapparat.Add("Mixer");

            Console.WriteLine
            ("=== Välj Köksapparat ===\n" +
            "1. " + Köksapparat[0] + "\n" +
            "2. " + Köksapparat[1] + "\n" +
            "3. " + Köksapparat[2] + "\n" +
            "4. " + Köksapparat[3] + "\n"); 


            /*
            Console.WriteLine
            ("=== Välj köksapparat ===\n" +
            "1. Mikro\n" +
            "2. Brödrost\n" +
            "3. Ugn\n" +
            "4. Mixer\n" +

            "\n0. Annan Köksapparat\n" +
            "-------------------------" +
            "\nVälj Köksapparat:");
            */

            int usingmenu = Convert.ToInt32(Console.ReadLine());

            if (usingmenu == 1)
            {
                Console.WriteLine("Använder Mikro");
            }
            else if (usingmenu == 2)
            {
                Console.WriteLine("Användr Brödrost");
            }
            else if (usingmenu == 3)
            {
                Console.WriteLine("Använder Ugn");
            }
            else if(usingmenu == 4)
            {
                Console.WriteLine("Använder Mixer");
            }
            else if(usingmenu == 10)
            {
                Console.WriteLine("Du lägger nu in en ny kökapparat i programmet");
                LäggTill();
            }
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







