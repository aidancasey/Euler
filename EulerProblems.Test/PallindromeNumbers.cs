using System;
using System.Collections.Generic;
using EulerProblems.Helpers;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerProblems.Test
{
    [TestClass]
    public class PallindromeNumbers
    {
        [TestMethod]
        public void Test_PallindromeNumbers_Valid_Values()
        {
            List<int> results = Pallindromes.GetPalindromeNumbers(2).ToList();
            Assert.IsTrue(results.Count == 9);
            Assert.IsTrue(results.Contains(99));
            Assert.IsTrue(results.Contains(66));
        }
    }
}
