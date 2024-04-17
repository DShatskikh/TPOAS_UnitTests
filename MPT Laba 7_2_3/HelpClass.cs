using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace MPT_Laba_6_2_3
{
    public class HelpClass : AbstractClass
    {
        public Clothe Clothe1;
        public Clothe Clothe2;

        public HelpClass()
        {
            Clothe1 = new Clothe();
            Clothe2 = new Clothe();
        }

        public void Display()
        {
            Console.WriteLine("Базовый: ");
            Clothe1.Display();
            Console.WriteLine();
            Console.WriteLine("Производный: ");
            Clothe2.Display();
            Console.WriteLine();
        }

        public override int GetAllPrice()
        {
            return Clothe1.GetPrice() + Clothe2.GetPrice();
        }
    }
}
