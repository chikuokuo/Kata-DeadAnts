using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class DeadAntsTest
    {
        //An orderly trail of ants is marching across the park picnic area.

        //It looks something like this:

        //..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..
        //But suddenly there is a rumour that a dropped chicken sandwich has been spotted on the ground ahead. The ants surge forward! Oh No, it's an ant stampede!!

        //Some of the slower ants are trampled, and their poor little ant bodies are broken up into scattered bits.

        //The resulting carnage looks like this:

        //...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t
        //Can you find how many ants have died?

        [TestMethod]
        public void String_Empty_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual(string.Empty, 0);
        }

        [TestMethod]
        public void String_ant_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("ant", 0);
        }

        [TestMethod]
        public void String_antant_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("antant", 0);
        }

        [TestMethod]
        public void String_anantant_ShouldReturn_One()
        {
            DeadAntsCalculateShouldEqual("anantant", 1);
        }

        [TestMethod]
        public void String_anantantan_ShouldReturn_Two()
        {
            DeadAntsCalculateShouldEqual("anantantan", 2);
        }

        [TestMethod]
        public void String_anantantana_ShouldReturn_Three()
        {
            DeadAntsCalculateShouldEqual("an ant ant an a", 3);
        }

        [TestMethod]
        public void String_anantantanSeparatet_ShouldReturn_Two()
        {
            DeadAntsCalculateShouldEqual("an .. ant. ant.. an.. t", 2);
        }

        [TestMethod]
        public void BasicTests()
        {
            DeadAnts deadAnts = new DeadAnts();
            Assert.AreEqual(0, deadAnts.DeadAntsCalculate("ant ant ant ant"));
            Assert.AreEqual(0, deadAnts.DeadAntsCalculate(null));
            Assert.AreEqual(2, deadAnts.DeadAntsCalculate("ant anantt aantnt"));
            Assert.AreEqual(1, deadAnts.DeadAntsCalculate("ant ant .... a nt"));
        }

        private static void DeadAntsCalculateShouldEqual(string input, int expected)
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
            if (string.IsNullOrEmpty(antsTeam)) return 0;

            var deadAnts = Regex.Replace(antsTeam.Replace("ant", ""), @"[^a-z]", "");

            return deadAnts == string.Empty ? 0 : deadAnts.GroupBy(antBody => antBody).Max(bodyGroup => bodyGroup.Count());
        }
    }
}
