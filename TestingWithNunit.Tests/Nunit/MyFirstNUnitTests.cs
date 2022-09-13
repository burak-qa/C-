using System;
using NUnit.Framework;

namespace TestingWithNunit.Tests
{
    public class MyFirstNUnitTests
    {
        [Test]
        public void IAmDoingGreat()
        {
            Console.Write("See you in the test output!");
            Assert.True(true);
        }

        [Test]
        public static void ThisIsAStaticTest()
        {

        }
    }
    
}