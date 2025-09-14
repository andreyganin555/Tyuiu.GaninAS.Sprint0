using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaninAS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.GaninAS.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionvalid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10,5));
        }
        public void CheckedMultiplicationvalid()
        {
            Assert.AreEqual(50,DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionvalid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }



    }
}
