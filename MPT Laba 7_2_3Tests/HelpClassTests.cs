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
    public class HelpClassTests
    {
        [TestMethod()]
        public void GetAllPrice_NotInit_0return()
        {
            HelpClass helpClass = new HelpClass();
            int expected = 0;

            int actual = helpClass.GetAllPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAllPrice_10and5_15return()
        {
            HelpClass helpClass = new HelpClass();
            helpClass.Clothe1 = new Clothe();
            helpClass.Clothe1.Init(1, 10);
            helpClass.Clothe2 = new Clothe();
            helpClass.Clothe2.Init(1, 5);
            int expected = 15;

            int actual = helpClass.GetAllPrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAllPrice_Minus_Error()
        {
            HelpClass helpClass = new HelpClass();
            helpClass.Clothe1 = new Clothe();
            helpClass.Clothe1.Init(1, -1);

            Assert.ThrowsException<Exception>(() => helpClass.GetAllPrice());
        }
    }
}