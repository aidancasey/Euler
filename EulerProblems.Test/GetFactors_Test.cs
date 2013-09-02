using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EulerProblems.Test
{
    [TestClass]
    public class GetFactors_Test
    {
        [TestMethod]
        public void Get_Factorys__ValidValues()
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
    }
}
