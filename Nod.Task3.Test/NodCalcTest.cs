﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nod.Task3.Library;

namespace Nod.Task3.Test
{
    [TestClass]
    public class NodCalcTest
    {
        [TestMethod]
        public void NodCalcValueTwoArgsTest()
        {
            int first = 15;
            int second = 21;
            int expected = 3;
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.Euclidean(ref time, first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NodCalcValueFourArgsTest()
        {
            int first = 16;
            int second = 32;
            int third = 36;
            int fourth = 64; 
            int expected = 4;
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.Euclidean(ref time, first, second, third, fourth);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NodCalcExceptionWithoutArgsTest()
        {
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.Euclidean(ref time);
        }

        // Binary EA

        [TestMethod]
        public void BinaryNodCalcValueTwoArgsTest()
        {
            int first = 15;
            int second = 21;
            int expected = 3;
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.EuclideanBinary(ref time, first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinaryNodCalcValueFourArgsTest()
        {
            int first = 16;
            int second = 32;
            int third = 36;
            int fourth = 64;
            int expected = 4;
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.EuclideanBinary(ref time, first, second, third, fourth);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BinaryNodCalcExceptionWithoutArgsTest()
        {
            TimeSpan time = new TimeSpan();

            int actual = NodCalc.EuclideanBinary(ref time);
        }

    }
}
