using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIf0()
        {
            int firstNumber = 0;
            int secondNumber = 0;

            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber %= secondNumber;
                }
                else
                {
                    secondNumber %= firstNumber;
                }
            }

            Assert.AreEqual((firstNumber == 0 ? secondNumber : firstNumber), 0);
        }

        [TestMethod]
        public void TestIfNot0()
        {
            int firstNumber = 28;
            int secondNumber = 20;

            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber %= secondNumber;
                }
                else
                {
                    secondNumber %= firstNumber;
                }
            }

            Assert.AreEqual((firstNumber == 0 ? secondNumber : firstNumber), 4);

        }

        [TestMethod]
        public void TestIfBgreaterThanA()
        {
            int firstNumber = 20;
            int secondNumber = 28;

            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber %= secondNumber;
                }
                else
                {
                    secondNumber %= firstNumber;
                }
            }

            Assert.AreEqual((firstNumber == 0 ? secondNumber : firstNumber), 4);

        }

        [TestMethod]
        public void TestIfEqual()
        {
            int firstNumber = 28;
            int secondNumber = 28;

            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber %= secondNumber;
                }
                else
                {
                    secondNumber %= firstNumber;
                }
            }

            Assert.AreEqual((firstNumber == 0 ? secondNumber : firstNumber), 28);

        }
    }
}
