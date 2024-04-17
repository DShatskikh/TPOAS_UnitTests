using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPT_Laba_6_2_3
{
    public class Clothe
    {
        private protected int _length;
        private protected int _price;

        public void Init(int length, int price)
        {
            _length = length;
            _price = price;
        }

        public void Read()
        {
            Console.WriteLine("Введите длину: ");
            _length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену: ");
            _price = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Длина: " + _length + " " + "Цена: " + _price);
        }

        public virtual int GetPrice()
        {
            if(_price < 0 || _length < 0)
            {
                throw new Exception();
            }

            return _length * _price;
        }
    }
}
