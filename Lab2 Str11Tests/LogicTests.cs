using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_Str11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Str11.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NoMatchesNoRepitition()
        {
            string word1 = "Процессор";
            string word2 = "Синхрофазотрон";

            Assert.AreEqual(Logic.Execution(word1, word2), "п - нет\r\nр - да\r\nо - да\r\nц - нет\r\nе - нет\r\nс - да");
        }

        [TestMethod()]
        public void MatchesAndRepetition()
        {
            string word1 = "Телега";
            string word2 = "Яд";

            Assert.AreEqual(Logic.Execution(word1, word2), "т - нет\r\nе - нет\r\nл - нет\r\nг - нет\r\nа - нет");
        }
    }
}