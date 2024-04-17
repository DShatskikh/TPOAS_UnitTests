using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPT_Laba_6_2_3
{
    internal class Atelier
    {
        private Clothe _type1;
        private Clothe _type2;
        private Clothe _type3;
        private int _count1;
        private int _count2;
        private int _count3;
        private int _costAccessories = 0;
        private String _name;

        public void Init(int price1, int lenght1, int count1,
                           int price2, int lenght2, int count2,
                           int price3, int lenght3, int count3, int costAccessories, String name)
        {
            _count1 = count1;
            _count2 = count2;
            _count3 = count3;

            _type1 = new Clothe();
            _type1.Init(price1, lenght1);
            _type2 = new Clothe();
            _type2.Init(price2, lenght2);
            _type3 = new Clothe();
            _type3.Init(price3, lenght3);

            _costAccessories = costAccessories;
            _name = name;
        }

        public void Read()
        {
            Console.WriteLine("Тип 1");
            Console.WriteLine("Введите колличество: ");
            _count1 = Convert.ToInt32(Console.ReadLine());
            _type1.Read();
            Console.WriteLine();

            Console.WriteLine("Тип 2");
            Console.WriteLine("Введите колличество: ");
            _count2 = Convert.ToInt32(Console.ReadLine());
            _type2.Read();
            Console.WriteLine();

            Console.WriteLine("Тип 3");
            Console.WriteLine("Введите колличество: ");
            _count3 = Convert.ToInt32(Console.ReadLine());
            _type3.Read();
            Console.WriteLine();
        }

        public void Display()
        {
            Console.WriteLine("Имя: " + _name);
            _type1.Display();
            _type2.Display();
            _type3.Display();
            Console.WriteLine("Аксессуары цена: " + _costAccessories);
        }

        public int GetAllPrice()
        {
            return _count1 * _type1.GetPrice()
                    + _count2 * _type2.GetPrice()
                    + _count3 * _type3.GetPrice()
                + _costAccessories;
        }

        public Clothe GetMostExpensive()
        {
            if (_type1.GetPrice() > _type2.GetPrice())
            {
                if (_type1.GetPrice() > _type3.GetPrice())
                {
                    return _type1;
                }
                else
                {
                    return _type3;
                }
            }
            else
            {
                if (_type2.GetPrice() > _type3.GetPrice())
                {
                    return _type2;
                }
                else
                {
                    return _type3;
                }
            }
        }

        public String GetName()
        {
            return _name;
        }
    }
}
