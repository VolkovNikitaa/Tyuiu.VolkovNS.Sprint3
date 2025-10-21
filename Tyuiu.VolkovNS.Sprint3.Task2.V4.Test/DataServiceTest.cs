using Tyuiu.VolkovNS.Sprint3.Task2.V4.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double sum = 0.021;
            Assert.AreEqual(sum, ds.GetMultiplySeries(1, 9));
        }
    }
}
