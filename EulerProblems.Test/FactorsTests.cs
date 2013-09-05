using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EulerProblems.Test
{
    [TestClass]
    public class FactorsTests
    {
        [TestMethod]
        public void Get_Factorys_Valid_Values()
        {
            var result = Factors.GetFactors(8).ToList();
            Assert.IsTrue(result.Contains(1));
            Assert.IsTrue(result.Contains(2));
            Assert.IsTrue(result.Contains(4));
            Assert.IsTrue(result.Contains(8));  
        }


        [TestMethod]
        public void Get_Factorys_Of_1_Returns_1()
        {
            var result = Factors.GetFactors(1).ToList();
            Assert.IsTrue(result.Contains(1));
        }

        /// <summary>
        /// considering the numbers 2,3,4,5,6
        /// the unique factors that arne't multiples of eachother are 2,3,5
        /// since 2X2 =4 and 2X3 = 6
        /// </summary>
        [TestMethod]
        
        public void GetUniqueFactor_Valid_Values()
        {
            var result = Factors.GetUniqueFactorsUpNumber(6).ToList();
            Assert.IsTrue(result.Count ==3);
            Assert.IsTrue(result.Contains(2));
            Assert.IsTrue(result.Contains(3));
            Assert.IsTrue(result.Contains(5));
        }
    }
}
