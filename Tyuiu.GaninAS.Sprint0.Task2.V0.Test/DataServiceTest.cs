using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaninAS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GaninAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Андрей";
            var res = DataSevice.GetMessage(name);

            Assert.AreEqual("Привет, Андрей", res);
        }
    }
}
