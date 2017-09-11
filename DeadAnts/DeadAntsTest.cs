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

        public void String_ant_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("ant", 0);
        }

        public void String_antant_ShouldReturn_Zero()
        {
            DeadAntsCalculateShouldEqual("antant", 0);
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
            if (antsTeam.Replace("ant","") == string.Empty)
            {
                return 0;
            }
            return 0;
        }
    }
}
