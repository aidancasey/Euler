using System;
using System.Collections.Generic;
using EulerProblems.Helpers;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerProblems.Test
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void Test_PallindromeNumbers_Valid_Values()
        {
            List<int> results = Numbers.GetPalindromeNumbers(2).ToList();
            Assert.IsTrue(results.Count == 9);
            Assert.IsTrue(results.Contains(99));
            Assert.IsTrue(results.Contains(66));
        }


        [TestMethod]
        public void Test_SumSquareFirstNNaturalNumbers_Valid_Values()
        {
            long expectedNumber = (1*1) + (2*2) + (3*3) + (4*4);
            long calculatedNumber = Numbers.SumSquareFirstNNaturalNumbers(4);
            Assert.IsTrue(expectedNumber == calculatedNumber, "Verifying sum of the square of the first 4 natural numbers is correct");
        }

        [TestMethod]
        public void Test_SumFirstNNaturalNumbers_Valid_Values()
        {
            long expectedNumber = 1+2+3+4+5+6+7;
            var calculatedNumber = Numbers.SumFirstNNaturalNumbers(7);
            Assert.IsTrue(expectedNumber == calculatedNumber, "Verifying sum of first 7 natural numbers is correct");


        }

    }
}
