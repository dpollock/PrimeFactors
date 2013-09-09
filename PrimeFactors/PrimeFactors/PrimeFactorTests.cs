using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactors
{
    [TestClass]
    public class PrimeFactorTests
    {
        [TestMethod]
        public void Factorize_1()
        {
            var expectedResult = new List<int>();
            var result = PrimeFactorer.Factorize(1);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_2()
        {
            var expectedResult = new List<int> { 2 };
            var result = PrimeFactorer.Factorize(2);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }


        [TestMethod]
        public void Factorize_3()
        {
            var expectedResult = new List<int> { 3 };
            var result = PrimeFactorer.Factorize(3);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_4()
        {
            var expectedResult = new List<int> { 2, 2 };
            var result = PrimeFactorer.Factorize(4);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_6()
        {
            var expectedResult = new List<int> { 2, 3 };
            var result = PrimeFactorer.Factorize(6);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_8()
        {
            var expectedResult = new List<int> { 2, 2, 2 };
            var result = PrimeFactorer.Factorize(8);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_9()
        {
            var expectedResult = new List<int> { 3, 3 };
            var result = PrimeFactorer.Factorize(9);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_100()
        {
            var expectedResult = new List<int> { 2, 2, 5, 5 };
            var result = PrimeFactorer.Factorize(100);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_4538()
        {
            var expectedResult = new List<int> { 2, 2269 };
            var result = PrimeFactorer.Factorize(4538);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void Factorize_1051()
        {
            var expectedResult = new List<int> { 1051 };
            var result = PrimeFactorer.Factorize(1051);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}
