using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Solostov18_10;

namespace Test18
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestResultat1()
        {
            double x = 4;
            double a = 1;
            double b = 2;
            double c = 2;

            Assert.AreEqual(UnitTest.Resultat(a, x, b, c), "F=-18");
        }

        [TestMethod]
        public void TestResultat2()
        {
            double x = 15;
            double a = 10;
            double b = 6;
            double c = 0;

            Assert.AreEqual(UnitTest.Resultat(a, x, b, c), "F=-∞");
        }

        [TestMethod]
        public void TestResultat3()
        {
            double x = 5;
            double a = 2;
            double b = 1;
            double c = -1;

            Assert.AreEqual(UnitTest.Resultat(a, x, b, c), "F=5");
        }

        [TestMethod]
        public void TestUslovie1()
        {
            Assert.IsTrue(UnitTest.Uslovie1(4, 1));
        }

        [TestMethod]
        public void TestUslovie2()
        {
            Assert.IsTrue(UnitTest.Uslovie2(7, 0));
        }
    }
}