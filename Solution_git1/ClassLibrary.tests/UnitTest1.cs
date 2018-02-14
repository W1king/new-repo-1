using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMedia()
        {
            double num1 = 5;
            double num2 = 2;
            double ris = 3.5;
            double media = (num1 + num2) / 2;
            media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, media);
        }
        public void TestMedia1()
        {
            double num1 = 3;
            double num2 = 4;
            double ris = 3.5;
            double media = (num1 + num2) / 2;
            media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, media);
        }
        public void TestMedia2()
        {
            double num1 = 7;
            double num2 = 7;
            double ris = 7;
            double media = (num1 + num2) / 2;
            media = Calc.Media(num1, num2);
            Assert.AreEqual(ris, media);
        }
        public void TestMax()
        {
            double num1 = 5;
            double num2 = 2;
            double ris = 3.5;
            double max = 
            max = Calc.Media(num1, num2);
            Assert.AreEqual(ris, max);
        }
        public void TestMin()
        {
            double num1 = 5;
            double num2 = 2;
            double ris = 3.5;
            double min =
            min = Calc.Media(num1, num2);
            Assert.AreEqual(ris, min);
        }
    }
}
