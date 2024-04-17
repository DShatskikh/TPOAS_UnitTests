using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPT_Laba_6_2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPT_Laba_6_2_3.Tests
{
    [TestClass()]
    public class ClotheTests
    {
        [TestMethod()]
        public void GetPrice_10and3_30return()
        {
            int expected = 30;
            Clothe clothe = new Clothe();
            int lenght = 10;
            int price = 3;
            clothe.Init(lenght, price);

            int actual = clothe.GetPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPrice_Minus_Error()
        {
            Clothe clothe = new Clothe();
            clothe.Init(1, -1);

            Assert.ThrowsException<Exception>(() => clothe.GetPrice());
        }

        [TestMethod()]
        public void GetPrice_Zero_Error()
        {
            Clothe clothe = new Clothe();
            clothe.Init(0, 0);

            Assert.ThrowsException<Exception>(() => clothe.GetPrice());
        }

        [TestMethod()]
        public void GetPrice_0and1_Error()
        {
            Clothe clothe = new Clothe();
            clothe.Init(0, 1);

            Assert.ThrowsException<Exception>(() => clothe.GetPrice());
        }
    }
}