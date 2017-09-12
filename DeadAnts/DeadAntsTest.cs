using System;
using System.Collections.Generic;
using System.Linq;
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
        public void String_anantant_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("anantant", 1);
        }

        [TestMethod]
        public void String_anantantan_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("anantantan", 2);
        }

        [TestMethod]
        public void String_anantantana_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("an ant ant an a", 3);
        }

        [TestMethod]
        public void String_anantantanSeparatet_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("an .. ant. ant.. an.. t", 2);
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
            var deadAnts = antsTeam.Replace("ant", "");
            if (deadAnts == string.Empty)
            {
                return 0;
            }

            var antBodyPart = deadAnts.ToCharArray();
            var bodyACount = antBodyPart.Count(x => x == 'a');
            var bodyNCount = antBodyPart.Count(x => x == 'n');
            var bodyTCount = antBodyPart.Count(x => x == 't');

            return new []{ bodyACount, bodyNCount, bodyTCount }.Max();
        }
    }
}
