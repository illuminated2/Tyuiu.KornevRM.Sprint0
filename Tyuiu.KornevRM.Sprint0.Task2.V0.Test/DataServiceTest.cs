using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KornevRM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KornevRM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Руслан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Руслан", res);
        }
    }
}
