using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAssignment;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ DataRow("500", "4", "5", "600")]
        [DataRow("260", "8", "3", "322.4")]
        [DataRow("350", "2", "9", "413")]
        public void IntTest(string prin, string ra, string ti, string expected)
        {
            var saving = new Account();
            double principal = double.Parse(prin);
            double rate = double.Parse(ra);
            int time = int.Parse(ti);
            double expectedRes = double.Parse(expected);

            double amount = saving.Int(principal, rate, time);
            Assert.AreEqual(expectedRes, amount);


            //double amount = saving.Int(500, 4, 5);
            //Assert.AreEqual(600, amount);
        }
    }
}
