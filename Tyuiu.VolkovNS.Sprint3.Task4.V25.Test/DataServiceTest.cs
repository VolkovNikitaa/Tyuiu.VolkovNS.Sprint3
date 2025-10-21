using Tyuiu.VolkovNS.Sprint3.Task4.V25.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 8.995;
            Assert.AreEqual(y, ds.Calculate(-5, 5));
        }
    }
}
