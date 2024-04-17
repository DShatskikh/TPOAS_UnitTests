using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPT_Laba_6_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelpClass _helpClass1 = new HelpClass();
            HelpClass1 _helpClass2 = new HelpClass1();
            HelpClass2 _helpClass3 = new HelpClass2();

            _helpClass1.Display();
            _helpClass2.Display();
            _helpClass3.Display();
            Console.ReadKey();
        }
    }
}
