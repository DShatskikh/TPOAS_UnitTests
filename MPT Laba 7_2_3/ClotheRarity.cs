using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPT_Laba_6_2_3
{
    internal class ClotheRarity : Clothe
    {
        private int _rarity = 1;

        public void Init(int length, int price, int rarity)
        {
            base.Init(length, price);

            _rarity = rarity;
        }

        public override int GetPrice()
        {
            return base.GetPrice() * _rarity;
        }

        public override void Display()
        {
            Console.WriteLine("Длина: " + _length + " " + "Цена: " + _price + " " + "Мастерство: " + _rarity);
        }
    }
}
