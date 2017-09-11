using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class DeadAntsTest
    {
        [TestMethod]
        public void String_Empty_ShouldReturn_Zero()
        {
            StringAverageShouldEqual(string.Empty, 0);
        }

        private static void StringAverageShouldEqual(string input, int expected)
        {
            DeadAnts deadAnts = new DeadAnts();
            var result = deadAnts.DeadAntsCalculate(input);

            Assert.AreEqual(expected, result);
        }
    }

    public class DeadAnts
    {
        public int DeadAntsCalculate(string antsTeam)
        {
            return 0;
        }
    }
}
