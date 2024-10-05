using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using Tyuiu.TodikovDE.Sprint2.Task1.V10.Lib;
namespace Tyuiu.TodikovDE.Sprint2.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;
            bool[] res = new bool[6];
            bool[] wait = new bool[6] { true, false, false, false, true, false };
            CollectionAssert.AreEquivalent(wait, res);
        }
    }
}