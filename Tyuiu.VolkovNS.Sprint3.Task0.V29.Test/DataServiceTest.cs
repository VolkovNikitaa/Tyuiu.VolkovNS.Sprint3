using Tyuiu.VolkovNS.Sprint3.Task0.V29.Lib;

namespace Tyuiu.VolkovNS.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double sum = 2.065;
            Assert.AreEqual(sum, ds.GetSumSeries(0.5, 1, 10));
        }
    }
}
