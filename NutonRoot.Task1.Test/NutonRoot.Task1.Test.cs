using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutonRoot.Task1.Library;

namespace NutonRoot.Task1.Test
{
    [TestClass]
    public class NutonCalcTest
    {
        [TestMethod]
        public void RootOfTest()
        {
            double argument = 3.14;
            int rootPower = 2;
            double accuracy= 0.0001;

            double actual = NutonCalc.RootOf(argument, rootPower, accuracy);

            double mathPower  = (1 / (double)rootPower);
            double expected = Math.Pow(argument,  mathPower);

            Assert.AreEqual(expected, actual, accuracy, "Root of argument not calculated correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RootOfNegativeArgumenAndEvenRootPowerTest()
        {
            double argument = -8.85;
            int rootPower = 4;
            double accuracy = 0.0001;

            double actual = NutonCalc.RootOf(argument, rootPower, accuracy);

            double mathPower = (1 / (double)rootPower);
            double expected = Math.Pow(argument, mathPower);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RootOfNegativeAccuracyTest()
        {
            double argument = 8.85;
            int rootPower = 4;
            double accuracy = -3;

            double actual = NutonCalc.RootOf(argument, rootPower, accuracy);

            double mathPower = (1 / (double)rootPower);
            double expected = Math.Pow(argument, mathPower);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RootOfZeroPowerTest()
        {
            double argument = 8.85;
            int rootPower = 4;
            double accuracy = -3;

            double actual = NutonCalc.RootOf(argument, rootPower, accuracy);

            double mathPower = (1 / (double)rootPower);
            double expected = Math.Pow(argument, mathPower);
        }
    }
}
