using System;

namespace MPT_Laba_6_2_3
{
    public class HelpClass2 : AbstractClass
    {
        private Clothe Clothe;
        private ClotheRarity ClotheRarity;

        public HelpClass2()
        {
            Clothe = new Clothe();
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