using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_or_Even
{
    [TestFixture]
    public class OddOrEvenTest
    {
        [Test]
        public void Test_IsEven()
        {
            int[] arr = new int[] { 1, 2, 3 };
            int SumOfArray = arr.Sum();

            if (SumOfArray % 2 == 0)
            {
                Assert.Pass("Even");
            }
            else
            {
                Assert.Fail("Sum was not even");
            }
        }

        [Test]
        public void Test_IsOdd()
        {
            int[] arr = new int[] { 5, 5, 1 };
            int SumOfArray = arr.Sum();

            if (SumOfArray % 2 != 0)
            {
                Assert.Pass("Odd");
            }
            else
            {
                Assert.Fail("Sum was not odd");
            }

        }
    }
}