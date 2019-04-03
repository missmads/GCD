using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCDTest
{
    [TestClass]
    public class UnitTest1
    {
        //Check the while loop if the inputs are equal to 0
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

        //Check the while loop if the inputs are not equal to zero, and check the if statement when the first number is greater than the second
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

        //Check the if statement when the second number is greater than the first and when the else runs second bigger than first
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

        //Check the if statement when the numbers are the same and when the else runs with identical numbers
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
