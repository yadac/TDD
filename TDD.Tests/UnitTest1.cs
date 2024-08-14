using TDD.Model;

namespace TDD.Tests
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }
        [TestMethod]
        public void TestEquality()
        {
            Dollar one = new Dollar(5);
            Dollar two = new Dollar(5);
            Dollar three = new Dollar(6);
            Assert.IsTrue(one.Equals(two));
            Assert.IsFalse(one.Equals(three));
        }
        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
    }
}