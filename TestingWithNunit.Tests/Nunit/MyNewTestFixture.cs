using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MyNewTestFixture
    {
        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected ", "actual");
        }
        
        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected", "actual", "what does this even mean");
        }

        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.AreEqual("expected", "actual", "what does {0} mean to {1}", "testing", "you");
        }

        [Test]
        public void AreEqualNumbers()
        {
            Assert.AreEqual(1,2);
        }

        [Test]
        public void AreEqualNumbersWithADifferentType()
        {
            Assert.AreEqual(2,2d);
        }

        [Test]
        public void AreEqualNumbersWithinTolerance()
        {
            Assert.AreEqual(2,23,.5);
        }

        [Test]
        public void AreEqualArrays()
        {
            var expected = new int[] {1, 2, 3};
            var actual = new int[] {1, 3, 4};
            //Array.Sort(actual);
            Assert.AreEqual(expected, actual);
        }


    }

}