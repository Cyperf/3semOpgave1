using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3semOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3semOpgave1.Tests
{
    [TestClass()]
    public class TrophyTests
    {
        Trophy validTrophy = new Trophy("OL Skating", 2020);
        Trophy invalidEarlyYearTrophy = new Trophy("DM i Ølbong", 1969);

        [TestMethod()]
        public void ValidateCompetitionTest()
        {
            Assert.IsTrue(validTrophy.ValidateCompetition());
            Assert.IsTrue(invalidEarlyYearTrophy.ValidateCompetition());
        }
        [TestMethod()]
        public void ValidateYearTest() 
        {
            Assert.IsTrue(validTrophy.ValidateYear());
            Assert.IsFalse(invalidEarlyYearTrophy.ValidateYear());
        }
        [TestMethod()]
        public void ValidateAllTest()
        {
            Assert.IsTrue(validTrophy.ValidateAll());
        }
        
    }
}