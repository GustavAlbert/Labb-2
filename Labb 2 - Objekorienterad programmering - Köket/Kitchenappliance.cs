using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Objekorienterad_programmering___Köket
{
    public class Kitchenappliance
    {
        public string Type { get; set; }
        public string Brand { get ; set ; }
        public bool IsFunctioning { get; set; }
        public int ID { get; set; }

        void Use()
        {
            throw new NotImplementedException();
        }
    }

    public class Kitchenappliances
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }
        public int ID { get; set; }

        void Use()
        {
            throw new NotImplementedException();
        }
    }
}
