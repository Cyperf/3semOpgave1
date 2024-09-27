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

        Trophy invalidCompetitionTrophy = new Trophy("OL", 2020);

        Trophy invalidEarlyYearTrophy = new Trophy("DM i Ølbong", 1969);

        Trophy invalidLateYearTrophy = new Trophy("EM i Ølbong", 2025);

        [TestMethod()]
        public void ValidateCompetitionTest()
        {
            Assert.IsTrue(validTrophy.ValidateCompetition());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidCompetitionTrophy.ValidateCompetition());

            Assert.IsTrue(invalidEarlyYearTrophy.ValidateCompetition());

            Assert.IsTrue(invalidLateYearTrophy.ValidateCompetition());

        }
        [TestMethod()]
        public void ValidateYearTest() 
        {
            Assert.IsTrue(validTrophy.ValidateYear());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>invalidEarlyYearTrophy.ValidateYear());

            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> invalidLateYearTrophy.ValidateYear());
        }
        [TestMethod()]
        public void ValidateAllTest()
        {
            Assert.IsTrue(validTrophy.ValidateAll());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidCompetitionTrophy.ValidateAll());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidEarlyYearTrophy.ValidateAll());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidLateYearTrophy.ValidateAll());
        }
        
    }
}