using System;

namespace MPT_Laba_6_2_3
{
    public class HelpClass1 : AbstractClass
    {
        private ClotheRarity Clothe;
        private ClotheRarity ClotheRarity;

        public HelpClass1()
        {
            Clothe = new ClotheRarity();
            ClotheRarity = new ClotheRarity();
        }

        public void Display()
        {
            Console.WriteLine("Базовый: ");
            Clothe.Display();
            Console.WriteLine();
            Console.WriteLine("Производный: ");
            ClotheRarity.Display();
            Console.WriteLine();
        }

        public override int GetAllPrice()
        {
            return Clothe.GetPrice() + ClotheRarity.GetPrice();
        }
    }
}
